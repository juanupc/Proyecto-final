

CREATE DATABASE SISTEMA_VENTA_PROYECTO

GO

USE SISTEMA_VENTA_PROYECTO

GO

create table ROL(
IdRol int primary key identity,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
)
go

create table PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
Descripcion varchar(100),
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
FechaRegistro datetime default getdate()
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
Telefono varchar(50),
IdRol int references ROL(IdRol),
Estado bit,
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

create table DETALLE_COMPRA(
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

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
go


insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values
('20','Empleado','@gmail.com','456',2,1)

select * from ROL
select * from USUARIO
select IdRol, Descripcion from ROL

select p.IdRol, p.Descripcion from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO u on u.IdRol = r.IdRol
where u.IdUsuario = 4

insert into ROL (Descripcion)
values ('Empleado')

delete from ROL
 where IdRol='5';

 select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado, r.IdRol, r.Descripcion from usuario u
 inner join rol r on r.IdRol = u.IdRol
/*
insert into PERMISO(IdRol, Descripcion) values
(1,'MenuUsuario'),
(1,'MenuMantenedor'),
(1,'MenuVentas'),
(1,'MenuCompras'),
(1,'MenuClientes'),
(1,'MenuProveedores'),
(1,'MenuReportes'),
(1,'MenuAcercaDe')

insert into PERMISO(IdRol, Descripcion) values

(2,'MenuVentas'),
(2,'MenuCompras'),
(2,'MenuClientes'),
(2,'MenuProveedores'),
(2,'MenuAcercaDe')*/


select * from USUARIO

create PROC SP_REGISTRARUSUARIO(
@Documento varchar (50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar (20),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar (500) output

)
as 
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''
	if not exists (select * from USUARIO where Documento = @Documento)
	begin
		insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado) values
		(@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
	end
	else
	set @Mensaje = 'No se puede repetir el documento para mas de un usuario'




end





DECLARE @idusuariogenerado int 
DECLARE	@Mensaje varchar (500)

exec SP_REGISTRARUSUARIO '123','PRUEBAS','TEST@GMAIL.COM','456',2,1,@idusuariogenerado output,@Mensaje output

select @idusuariogenerado
select @Mensaje

go

CREATE PROC SP_EDITARUSUARIO(

@IdUsuario int,
@Documento varchar (50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar (20),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar (500) output

)

as 
begin
	set @Respuesta = 0
	set @Mensaje = ''
	if not exists (select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
	begin
		update USUARIO set
		Documento = @Documento ,
		NombreCompleto = @NombreCompleto , 
		Correo = @Correo,
		Clave = @Clave, 
		IdRol = @IdRol,
		Estado = @Estado

		where IdUsuario = @IdUsuario

		set @Respuesta = 1
	end
	else
	set @Mensaje = 'No se puede repetir el documento para mas de un usuario'




end

GO

CREATE PROC SP_ELIMINARUSUARIO(

@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar (500) output

)

as 
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (Select * from COMPRA C 
	inner join USUARIO U on U.IdUsuario = C.IdUsuario
	where U.IdUsuario = @IdUsuario
	)
	Begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar debido a que el usuario se encuentra relacionado a una Compra\n'
	End

	if exists (Select * from VENTA V 
	inner join USUARIO U on U.IdUsuario = V.IdUsuario
	where U.IdUsuario = @IdUsuario
	)
	Begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar debido a que el usuario se encuentra relacionado a una Venta\n'
	End


	if(@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end


end



DECLARE @Respuesta bit 
DECLARE	@Mensaje varchar (500)

exec SP_EDITARUSUARIO 7,'123','PRUEBAS 2','TEST@GMAIL.COM','456',2,1,@Respuesta output,@Mensaje output

select @Respuesta
select @Mensaje