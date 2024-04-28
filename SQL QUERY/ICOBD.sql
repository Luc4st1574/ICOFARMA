use icofarmaBD

go

create table ROL(
    IdRol int primary key identity,
    Descripcion varchar(50),
    FechaRegistro datetime default getdate()
)

go

create table PERMISO(
    IdPermiso int primary key identity,
    IdRol int references ROL(IdRol),
    NombreMenu varchar(100),
    FechaRegistro datetime default getdate()
)

go

create table PROVEEDOR(
    IdProveedor int primary key identity,
    Documento varchar(50),
    RazonSocial varchar(50),
    Correo varchar(50),
    Telefono varchar(50),
    Estado bit,
    FechaRegistro datetime default getdate(),
    Direccion varchar(50)
)


go

create table CLIENTE(
    IdCliente int primary key identity,
    Documento varchar(50),
    NombreCompleto varchar(50),
    Correo varchar(50),
    Telefono varchar(50),
    Estado bit,
    FechaRegistro datetime default getdate()
)


go

create table USUARIO(
    IdUsuario int primary key identity,
    Documento varchar(50),
    NombreCompleto varchar(50),
    Correo varchar(50),
    Clave varchar(50),
    IdRol int references ROL(IdRol),
    Estado bit,
    Logged bit,
    FechaRegistro datetime default getdate()
)

go

create table CATEGORIA(
    IdCategoria int primary key identity,
    Descripcion varchar(100),
    Estado bit,
    FechaRegistro datetime default getdate()
)

go

create table PRODUCTO(
    IdProducto int primary key identity,
    Codigo varchar(50),
    Nombre varchar(50),
    Descripcion varchar(50),
    IdCategoria int references CATEGORIA(IdCategoria),
    Stock int not null default 0,
    PrecioCompra decimal(10,2) default 0,
    PrecioVenta decimal(10,2) default 0,
    Estado bit,
    FechaRegistro datetime default getdate()
)

go

create table COMPRA(
    IdCompra int primary key identity,
    IdUsuario int references USUARIO(IdUsuario),
    IdProveedor int references PROVEEDOR(IdProveedor),
    TipoDocumento varchar(50),
    NumeroDocumento varchar(50),
    MontoTotal decimal(10,2),
    FechaRegistro datetime default getdate()
)


go

create table DetalleCompra(
    IdDetalleCompra int primary key identity,
    IdCompra int references COMPRA(IdCompra),
    IdProducto int references PRODUCTO(IdProducto),
    PrecioCompra decimal(10,2) default 0,
    PrecioVenta decimal(10,2) default 0,
    Cantidad int,
    MontoTotal decimal(10,2),
    FechaRegistro datetime default getdate()
)

go


create table VENTA(
    IdVenta int primary key identity,
    IdUsuario int references USUARIO(IdUsuario),
    TipoDocumento varchar(50),
    NumeroDocumento varchar(50),
    DocumentoCliente varchar(50),
    NombreCliente varchar(100),
    MontoPago decimal(10,2),
    MontoCambio decimal(10,2),
    MontoTotal decimal(10,2),
    FechaRegistro datetime default getdate()
)

go

create table DetalleVenta(
    IdDetalleVenta int primary key identity,
    IdVenta int references VENTA(IdVenta),
    IdProducto int references PRODUCTO(IdProducto),
    PrecioVenta decimal(10,2),
    Cantidad int,
    SubTotal decimal(10,2),
    FechaRegistro datetime default getdate()
)

go


create table NEGOCIO(
IdNegocio int primary key,
Nombre varchar(60),
RUC varchar(60),
Direccion varchar(60),
Logo varbinary(max) NULL
)

go

/*************************** CREACION DE PROCEDIMIENTOS ALMACENADOS ***************************/
/*--------------------------------------------------------------------------------------------*/

go

/*************************** PROCEDIMIENTO DE USUARIO ***************************/

GO

create PROC SP_REGISTRARUSUARIO(
    @Documento varchar(50),
    @NombreCompleto varchar(100),
    @Correo varchar(100),
    @Clave varchar(100),
    @IdRol int,
    @Estado bit,
    @IdUsuarioResultado int output,
    @Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()

	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'


end

GO

create PROC SP_EDITARUSUARIO(
    @IdUsuario int,
    @Documento varchar(50),
    @NombreCompleto varchar(100),
    @Correo varchar(100),
    @Clave varchar(100),
    @IdRol int,
    @Estado bit,
    @Respuesta bit output,
    @Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	if not exists(select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
	begin
		update  usuario set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave,
		IdRol = @IdRol,
		Estado = @Estado
		where IdUsuario = @IdUsuario

		set @Respuesta = 1

	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'


end

GO

create PROC SP_ELIMINARUSUARIO(
    @IdUsuario int,
    @Respuesta bit output,
    @Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM COMPRA C
	INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n'
	END

	IF EXISTS (SELECT * FROM VENTA V
	INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
	WHERE U.IDUSUARIO = @IdUsuario
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n'
	END

	if(@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end

end

GO

/* ---------- PROCEDIMIENTOS PARA CATEGORIA -----------------*/

create PROC SP_RegistrarCategoria(
    @Descripcion varchar(50),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	begin
		insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'

end

GO

Create procedure sp_EditarCategoria(
    @IdCategoria int,
    @Descripcion varchar(50),
    @Estado bit,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin

	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion =@Descripcion and IdCategoria != @IdCategoria)
		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	end

end

GO

create procedure sp_EliminarCategoria(
    @IdCategoria int,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from CATEGORIA c
	 inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	 where c.IdCategoria = @IdCategoria
	)
	begin
	 delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'La categoria se encuentara relacionada a un producto'
	end

end

GO

/* ---------- PROCEDIMIENTOS PARA PRODUCTO -----------------*/

create PROC sp_RegistrarProducto(
    @Codigo varchar(20),
    @Nombre varchar(30),
    @Descripcion varchar(30),
    @IdCategoria int,
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
	begin
		insert into producto(Codigo,Nombre,Descripcion,IdCategoria,Estado) values (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
	 SET @Mensaje = 'Ya existe un producto con el mismo codigo'

end

GO

create procedure sp_ModificarProducto(
    @IdProducto int,
    @Codigo varchar(20),
    @Nombre varchar(30),
    @Descripcion varchar(30),
    @IdCategoria int,
    @Estado bit,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE codigo = @Codigo and IdProducto != @IdProducto)

		update PRODUCTO set
		codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		where IdProducto = @IdProducto
	ELSE
	begin
		SET @Resultado = 0
		SET @Mensaje = 'Ya existe un producto con el mismo codigo'
	end
end

GO

create PROC SP_EliminarProducto(
    @IdProducto int,
    @Respuesta bit output,
    @Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS (SELECT * FROM DETALLECOMPRA dc
	INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
	END

	IF EXISTS (SELECT * FROM DETALLEVENTA dv
	INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
	WHERE p.IdProducto = @IdProducto
	)
	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
	END

	if(@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1
	end

end

GO

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/

create PROC sp_RegistrarCliente(
@Documento varchar(50),
@NombreCompleto varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
	begin
		insert into CLIENTE(Documento,NombreCompleto,Correo,Telefono,Estado) values (
		@Documento,@NombreCompleto,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

GO

create PROC sp_ModificarCliente(
    @IdCliente int,
    @Documento varchar(50),
    @NombreCompleto varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Resultado bit output,
    @Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end

GO

/* ---------- PROCEDIMIENTOS PARA PROVEEDOR -----------------*/

create PROC sp_RegistrarProveedor(
    @Documento varchar(50),
    @RazonSocial varchar(50),
    @Direccion varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin
		insert into PROVEEDOR(Documento,RazonSocial,Direccion,Correo,Telefono,Estado) values (
		@Documento,@RazonSocial,@Direccion,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

GO

create PROC sp_ModificarProveedor(
    @IdProveedor int,
    @Documento varchar(50),
    @RazonSocial varchar(50),
    @Direccion varchar(50),
    @Correo varchar(50),
    @Telefono varchar(50),
    @Estado bit,
    @Resultado bit output,
    @Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Direccion = @Direccion,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end

GO

create procedure sp_EliminarProveedor(
    @IdProveedor int,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from PROVEEDOR p
	 inner join COMPRA c on p.IdProveedor = c.IdProveedor
	 where p.IdProveedor = @IdProveedor
	)
	begin
	 delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'El proveedor se encuentara relacionado a una compra'
	end

end

GO

/* PROCESOS PARA REGISTRAR UNA COMPRA */

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[IdProducto] [int] NULL,
	[PrecioCompra] [decimal](18, 2) NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[Cantidad] [int] NULL,
	[MontoTotal] [decimal](18, 2) NULL
)

GO

CREATE PROCEDURE sp_RegistrarCompra(
    @IdUsuario int,
    @IdProveedor int,
    @TipoDocumento varchar(500),
    @NumeroDocumento varchar(500),
    @MontoTotal decimal(18,2),
    @DetalleCompra [EDetalle_Compra] READONLY,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin

	begin try

		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into COMPRA(IdUsuario,IdProveedor,TipoDocumento,NumeroDocumento,MontoTotal)
		values(@IdUsuario,@IdProveedor,@TipoDocumento,@NumeroDocumento,@MontoTotal)

		set @idcompra = SCOPE_IDENTITY()

		insert into DETALLECOMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
		select @idcompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra


		update p set p.Stock = p.Stock + dc.Cantidad,
		p.PrecioCompra = dc.PrecioCompra,
		p.PrecioVenta = dc.PrecioVenta
		from PRODUCTO p
		inner join @DetalleCompra dc on dc.IdProducto= p.IdProducto

		commit transaction registro


	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end

GO

/* PROCESOS PARA REGISTRAR UNA VENTA */

CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[IdProducto] [int] NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[Cantidad] [int] NULL,
	[SubTotal] [decimal](18, 2) NULL
)
GO

create procedure usp_RegistrarVenta(
    @IdUsuario int,
    @TipoDocumento varchar(500),
    @NumeroDocumento varchar(500),
    @DocumentoCliente varchar(500),
    @NombreCliente varchar(500),
    @MontoPago decimal(18,2),
    @MontoCambio decimal(18,2),
    @MontoTotal decimal(18,2),
    @DetalleVenta [EDetalle_Venta] READONLY,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin

	begin try

		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin  transaction registro

		insert into VENTA(IdUsuario,TipoDocumento,NumeroDocumento,DocumentoCliente,NombreCliente,MontoPago,MontoCambio,MontoTotal)
		values(@IdUsuario,@TipoDocumento,@NumeroDocumento,@DocumentoCliente,@NombreCliente,@MontoPago,@MontoCambio,@MontoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into DETALLEVENTA(IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal)
		select @idventa,IdProducto,PrecioVenta,Cantidad,SubTotal from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end

GO

create PROC sp_ReporteCompras(
     @fechainicio varchar(10),
     @fechafin varchar(10),
     @idproveedor int
 )
  as
 begin

  SET DATEFORMAT dmy;
   select
 convert(char(10),c.FechaRegistro,103)[FechaRegistro],c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,
 u.NombreCompleto[UsuarioRegistro],
 pr.Documento[DocumentoProveedor],pr.RazonSocial,
 p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]
 from COMPRA c
 inner join USUARIO u on u.IdUsuario = c.IdUsuario
 inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
 inner join DETALLECOMPRA dc on dc.IdCompra = c.IdCompra
 inner join PRODUCTO p on p.IdProducto = dc.IdProducto
 inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
 where CONVERT(date,c.FechaRegistro) between @fechainicio and @fechafin
 and pr.IdProveedor = iif(@idproveedor=0,pr.IdProveedor,@idproveedor)
 end

GO

CREATE PROC sp_ReporteVentas(
     @fechainicio varchar(10),
     @fechafin varchar(10)
 )
 as
 begin
 SET DATEFORMAT dmy;
 select
 convert(char(10),v.FechaRegistro,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumento,v.MontoTotal,
 u.NombreCompleto[UsuarioRegistro],
 v.DocumentoCliente,v.NombreCliente,
 p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dv.PrecioVenta,dv.Cantidad,dv.SubTotal
 from VENTA v
 inner join USUARIO u on u.IdUsuario = v.IdUsuario
 inner join DETALLEVENTA dv on dv.IdVenta = v.IdVenta
 inner join PRODUCTO p on p.IdProducto = dv.IdProducto
 inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
 where CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
end

GO

CREATE PROCEDURE ActualizarLoggedFalse
    @IdUsuario INT
AS
BEGIN
    UPDATE Usuario
    SET Logged = 0
    WHERE IdUsuario = @IdUsuario;
END
GO

CREATE PROCEDURE ActualizarLoggedTrue
    @IdUsuario INT
AS
BEGIN
    UPDATE Usuario
    SET Logged = 1
    WHERE IdUsuario = @IdUsuario;
END

GO

/****************** INSERTAMOS REGISTROS A LAS TABLAS ******************/
/*---------------------------------------------------------------------*/

insert into rol (Descripcion)
 values('Administrador')

GO

insert into rol (Descripcion)
 values('Empleado')

GO

insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado, Logged)
values
 ('74636060','lsantillan','lsantillan@icofarma.pe','123',1,1,1)

GO

insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado, Logged)
values
('75624045','kalva','kalva@icofarma.pe','456',2,1,1)

GO

insert into PERMISO(IdRol,NombreMenu) values
(1,'btnUsuarios'),
(1,'btnMantenedor'),
(1,'btnVentas'),
(1,'btnCompras'),
(1,'btnClientes'),
(1,'btnProveedores'),
(1,'btnReportes')


GO

insert into PERMISO(IdRol,NombreMenu) values
(2,'btnVentas'),
(2,'btnCompras'),
(2,'btnClientes'),
(2,'btnProveedores')

GO

insert into NEGOCIO(IdNegocio,Nombre,RUC,Direccion,Logo) values
(1,'ICOFARMA','10711219400 ','Av bolivia 735',null)