USE [Tp_Final]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/16/2018 03:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Sueldo] [money] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Empleados] ([IdEmpleado], [Nombre], [Apellido], [Telefono], [Direccion], [Mail], [Sueldo]) VALUES (N'1', N'pepe', N'luis', N'41775522', N'lola', N'hola@hotmail.com', 2000.0000)
/****** Object:  Table [dbo].[Proveedor]    Script Date: 12/16/2018 03:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProv] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[CUIT] [varchar](50) NULL,
	[Ciudad] [varchar](50) NULL,
	[Mail_o_Web] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Proveedor] ([IdProv], [Nombre], [Telefono], [Direccion], [CUIT], [Ciudad], [Mail_o_Web]) VALUES (N'1', N'Faber castel', N'5522111', N'calle falsa 123', N'2015442336', N'2015442336', N'fabercastell@gmail.com')
INSERT [dbo].[Proveedor] ([IdProv], [Nombre], [Telefono], [Direccion], [CUIT], [Ciudad], [Mail_o_Web]) VALUES (N'2', N'dadsada', N'123241412', N'dasxcsadad', N'14143151', N'14143151', N'daadsdad')
INSERT [dbo].[Proveedor] ([IdProv], [Nombre], [Telefono], [Direccion], [CUIT], [Ciudad], [Mail_o_Web]) VALUES (N'4', N'dsadadw', N'2311424', N'13213', N'412414124', N'412414124', N'dwqdqdwq')
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/16/2018 03:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[CUIT] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Compras_Realizadas] [int] NULL,
	[direccion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CUIT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clientes] ([CUIT], [Nombre], [Apellido], [Telefono], [Mail], [Compras_Realizadas], [direccion]) VALUES (N'201552336', N'pepe', N'jaja', N'1445222', N'mail@example.com', 1, N'calle original')
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/16/2018 03:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Detalle] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre], [Detalle]) VALUES (N'1', N'aaaaaaaaaaaaaaaaaa', N'1')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre], [Detalle]) VALUES (N'2', N'carpetas', N'carpetas y utiles')
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre], [Detalle]) VALUES (N'3', N'lapices', N'lapices negros')
/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarEmpleado]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM empleados
	WHERE IdEmpleado=@idpro
	end
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminarProveedor]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarProveedor]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM Proveedor
	WHERE IdProv=@idpro
	end
	RETURN
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[Nro_Factura] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NULL,
	[Total] [money] NULL,
	[Metodo_Pago] [varchar](50) NULL,
	[CUIT_Cliente] [varchar](50) NULL,
	[Interes] [int] NULL,
	[Total_IVA] [money] NULL,
	[IdEmpleado] [varchar](50) NULL,
	[fecha] [smalldatetime] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[Nro_Factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ventas] ([Nro_Factura], [Tipo], [Total], [Metodo_Pago], [CUIT_Cliente], [Interes], [Total_IVA], [IdEmpleado], [fecha]) VALUES (N'1', N'A', 5.0000, N'Efectivo', N'201552336', 10, 6.0500, N'1', CAST(0xA9B80000 AS SmallDateTime))
/****** Object:  StoredProcedure [dbo].[modificar_empleados]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modificar_empleados] (@idemp varchar(50) ,@nombre varchar(50),@apellido varchar(50),@telefono varchar(50),@direccion varchar(50),@mail varchar(50),@sueldo money)
as begin
update Empleados
set Nombre = @nombre,apellido=@apellido,telefono=@telefono,direccion=@direccion,mail=@mail,sueldo=@sueldo
where @idemp = Idempleado
end
GO
/****** Object:  StoredProcedure [dbo].[modificar_Clientes]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modificar_Clientes] (@cuit varchar(50) ,@nombre varchar(50),@apellido varchar(50),@telefono varchar(50),@direccion varchar(50),@mail varchar(50),@compras int)
as begin
update Clientes
set Nombre = @nombre,apellido=@apellido,telefono=@telefono,direccion=@direccion,mail=@mail,Compras_Realizadas=@compras
where @cuit = CUIT
end
GO
/****** Object:  StoredProcedure [dbo].[modificar_Categoria]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificar_Categoria](@idcat varchar(50) ,@nombre varchar(50),@detalle varchar(50))
as begin
update categoria
set Nombre =@nombre , Detalle =@detalle
where IdCategoria = @idcat;
end
GO
/****** Object:  StoredProcedure [dbo].[cargar_proveedor]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_proveedor] @idProv nvarchar(50), @nombre nvarchar(50),@telefono nvarchar(50),
@direccion nvarchar(50),@cuit nvarchar(50), @ciudad nvarchar(50) ,@mail nvarchar(50) 
AS
BEGIN 
SET NOCOUNT ON
INSERT INTO Proveedor 
 (
IdProv, Nombre , Telefono, Direccion , CUIT, Ciudad, Mail_o_Web				
 )
 values (@idProv,@nombre,@telefono,@direccion,@cuit,@ciudad,@mail)
 end;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarCliente]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarCliente]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM clientes
	WHERE cuit=@idpro
	end;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarCategoria]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarCategoria]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM Categoria
	WHERE IdCategoria=@idpro
	end
	RETURN
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compras](
	[Nro_Factura] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NULL,
	[Total] [money] NULL,
	[Medio_Pago] [varchar](50) NULL,
	[IdProveedor] [varchar](50) NOT NULL,
	[Interes] [int] NULL,
	[Total_IVA] [money] NULL,
	[fecha] [smalldatetime] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[Nro_Factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Compras] ([Nro_Factura], [Tipo], [Total], [Medio_Pago], [IdProveedor], [Interes], [Total_IVA], [fecha]) VALUES (N'1', N'A', 40.0000, N'Efectivo', N'1', 10, 52.1000, CAST(0xA9B80000 AS SmallDateTime))
INSERT [dbo].[Compras] ([Nro_Factura], [Tipo], [Total], [Medio_Pago], [IdProveedor], [Interes], [Total_IVA], [fecha]) VALUES (N'2', N'A', 12.0000, N'Efectivo', N'1', -10, 14.5200, CAST(0xA9B90000 AS SmallDateTime))
/****** Object:  StoredProcedure [dbo].[cargar_clientes]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_clientes] @cuit nvarchar(50), @nombre nvarchar(50),@apellido nvarchar(50),@telefono nvarchar(50),@mail nvarchar(50), @compras int , @direccion nvarchar(50)
AS
BEGIN 
SET NOCOUNT ON
INSERT INTO Clientes 
 (
CUIT, Nombre, Apellido, Telefono , Mail, Compras_Realizadas,direccion		
 )
 values (@cuit,@nombre,@apellido,@telefono,@mail,@compras,@direccion)
 end;
GO
/****** Object:  StoredProcedure [dbo].[cargar_categoria]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_categoria] @IdCat nvarchar(50), @nombre nvarchar(50),@detalle nvarchar(50)
AS
BEGIN
SET NOCOUNT ON
INSERT INTO Categoria
 (
IdCategoria, Nombre, Detalle				
 )
 values (@IdCat,@nombre,@detalle)
 end;
GO
/****** Object:  StoredProcedure [dbo].[cargar_empleados]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_empleados] @idemp nvarchar(50), @nombre nvarchar(50),@apellido nvarchar(50),
@telefono nvarchar(50),@direccion nvarchar(50), @mail nvarchar(50) ,@sueldo money 
AS
BEGIN 
SET NOCOUNT ON
INSERT INTO Empleados 
 (
IdEmpleado, Nombre, Apellido, Telefono , Direccion, Mail, Sueldo				
 )
 values (@idemp,@nombre,@apellido,@telefono,@direccion,@mail,@sueldo)
 end;
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProd] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[IdCat] [varchar](50) NULL,
	[Precio_x_Unidad] [money] NULL,
	[Stock] [varchar](50) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Productos] ([IdProd], [Nombre], [IdCat], [Precio_x_Unidad], [Stock]) VALUES (N'1', N'lapizfabercastel', N'3', 5.0000, N'20')
INSERT [dbo].[Productos] ([IdProd], [Nombre], [IdCat], [Precio_x_Unidad], [Stock]) VALUES (N'2', N'a', N'1', 21.0000, N'0')
INSERT [dbo].[Productos] ([IdProd], [Nombre], [IdCat], [Precio_x_Unidad], [Stock]) VALUES (N'3', N'q', N'1', 1.0000, N'0')
/****** Object:  StoredProcedure [dbo].[modificar_Proveedor]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificar_Proveedor] (@cuit varchar(50) ,@nombre varchar(50),@ciudad varchar(50),@direccion varchar(50),@mail varchar(50),@telefono varchar(50))
as begin
update Proveedor
set Nombre = @nombre,telefono=@telefono,direccion=@direccion,Mail_o_Web=@mail,ciudad=@ciudad
where @cuit = CUIT
end
GO
/****** Object:  StoredProcedure [dbo].[modificar_Productos]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modificar_Productos] (@idprod varchar(50) ,@nombre varchar(50),@idcat varchar(50),@precio float)
as begin
update Productos
set Nombre = @nombre,IdCat=@idcat,precio_x_unidad=@precio
where IdProd = @idprod;
end
GO
/****** Object:  StoredProcedure [dbo].[cargar_ventas]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_ventas] @nrofact nvarchar(50), @tipo nvarchar(50),@total money,@medio_pago nvarchar(50),@cuit nvarchar(50), 
 @interes int ,@totaliva money,@idemp nvarchar(50),@fecha smalldatetime
AS
BEGIN 
SET NOCOUNT ON
INSERT INTO Ventas 
 (
Nro_Factura, Tipo, Total, Metodo_Pago,CUIT_Cliente , Interes ,Total_IVA,IdEmpleado,fecha
 )
 values (@nrofact,@tipo,@total,@medio_pago,@cuit,@interes,@totaliva,@idemp,@fecha)
 end;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarCompras]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarCompras]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM compras
	WHERE Nro_Factura=@idpro
	end
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[cargar_compras]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_compras] @nrofact nvarchar(50), @tipo nvarchar(50),@total money,@medio_pago nvarchar(50),@idprov nvarchar(50),
  @interes int ,@totaliva money , @fecha smalldatetime
AS
BEGIN 
SET NOCOUNT ON
INSERT INTO Compras 
 (
Nro_Factura, Tipo, Total, Medio_Pago , IdProveedor, Interes ,Total_IVA,fecha		
 )
 values (@nrofact,@tipo,@total,@medio_pago,@idprov,@interes,@totaliva,@fecha)
 end;
GO
/****** Object:  StoredProcedure [dbo].[cargar_Productos]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cargar_Productos] @idprod nvarchar(50), @nombre nvarchar(50),@idcat nvarchar(50),
@precio float,@stock nvarchar(50) 
AS
BEGIN 
SET NOCOUNT ON
INSERT INTO Productos
 (
IdProd, Nombre,IdCat , Precio_x_Unidad, Stock				
 )
 values (@idprod,@nombre,@idcat,@precio,@stock)
 end;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarVentas]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarVentas]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM Ventas
	WHERE Nro_Factura=@idpro
	end
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminarProducto]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarProducto]
	(
	@idpro nvarchar (50)
	) 
	AS
	begin
	DELETE FROM productos
	WHERE IdProd=@idpro
	end
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminardetalleVenta]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminardetalleVenta]
	(
	@idpro nvarchar (50),
	@idfact nvarchar (50)
	) 
	AS
	begin
	DELETE FROM Detalle_x_Venta
	WHERE Nro_Factura=@idfact and IdProd =@idpro
	end
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminardetalleCompra]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminardetalleCompra]
	(
	@idpro nvarchar (50),
	@idfact nvarchar (50)
	) 
	AS
	begin
	DELETE FROM Detalle_x_Compra
	WHERE Nro_Factura=@idfact and IdProd =@idpro
	end
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[cargar_detalle_venta]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargar_detalle_venta] @nrofact nvarchar(50) , @idprod nvarchar(50), @cantidad int ,@precioxuni money
as begin
insert into detalle_x_venta (Nro_Factura , idprod , cantidad ,Precio_x_Unidad)
select @nrofact , @idprod , @cantidad ,@precioxuni
end
GO
/****** Object:  StoredProcedure [dbo].[cargar_detalle_compra]    Script Date: 12/16/2018 03:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargar_detalle_compra] @nrofact nvarchar(50) , @idprod nvarchar(50), @cantidad int ,@precioxuni money
as begin
insert into detalle_x_compra (Nro_Factura , idprod , cantidad ,Precio_x_Unidad)
select @nrofact , @idprod , @cantidad ,@precioxuni
end
GO
/****** Object:  ForeignKey [FK_Ventas_Clientes]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([CUIT_Cliente])
REFERENCES [dbo].[Clientes] ([CUIT])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
/****** Object:  ForeignKey [FK_Ventas_Empleados]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleados]
GO
/****** Object:  ForeignKey [FK_Compras_Proveedor]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedor] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProv])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedor]
GO
/****** Object:  ForeignKey [FK_Productos_Categoria1]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categoria1] FOREIGN KEY([IdCat])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categoria1]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Venta_Productos]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Detalle_x_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Venta_Productos] FOREIGN KEY([IdProd])
REFERENCES [dbo].[Productos] ([IdProd])
GO
ALTER TABLE [dbo].[Detalle_x_Venta] CHECK CONSTRAINT [FK_Detalle_x_Venta_Productos]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Venta_Ventas]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Detalle_x_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Venta_Ventas] FOREIGN KEY([Nro_Factura])
REFERENCES [dbo].[Ventas] ([Nro_Factura])
GO
ALTER TABLE [dbo].[Detalle_x_Venta] CHECK CONSTRAINT [FK_Detalle_x_Venta_Ventas]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Compra_Compras]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Detalle_x_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Compra_Compras] FOREIGN KEY([Nro_Factura])
REFERENCES [dbo].[Compras] ([Nro_Factura])
GO
ALTER TABLE [dbo].[Detalle_x_Compra] CHECK CONSTRAINT [FK_Detalle_x_Compra_Compras]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Compra_Productos1]    Script Date: 12/16/2018 03:33:20 ******/
ALTER TABLE [dbo].[Detalle_x_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Compra_Productos1] FOREIGN KEY([IdProd])
REFERENCES [dbo].[Productos] ([IdProd])
GO
ALTER TABLE [dbo].[Detalle_x_Compra] CHECK CONSTRAINT [FK_Detalle_x_Compra_Productos1]
GO
