USE [tp_final]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminarProveedor]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Compras]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[modificar_empleados]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[modificar_Clientes]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[modificar_Categoria]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminarCliente]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminarCategoria]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_clientes]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_categoria]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_empleados]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_proveedor]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[modificar_Proveedor]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Table [dbo].[Detalle_x_Venta]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Detalle_x_Venta](
	[Nro_Factura] [varchar](50) NOT NULL,
	[IdProd] [varchar](50) NOT NULL,
	[Cantidad] [varchar](50) NULL,
	[Precio_x_Unidad] [money] NULL,
 CONSTRAINT [PK_Detalle_x_Venta_1] PRIMARY KEY CLUSTERED 
(
	[Nro_Factura] ASC,
	[IdProd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_x_Compra]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_x_Compra](
	[Nro_Factura] [varchar](50) NOT NULL,
	[IdProd] [varchar](50) NOT NULL,
	[Cantidad] [varchar](50) NULL,
	[Precio_x_Unidad] [money] NULL,
 CONSTRAINT [PK_Detalle_x_Compra_1] PRIMARY KEY CLUSTERED 
(
	[Nro_Factura] ASC,
	[IdProd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[modificar_Productos]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_ventas]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_Productos]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminarCompras]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_compras]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Trigger [SumarVentasCliente]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[SumarVentasCliente]
 on [dbo].[Ventas]
 after insert
 as
 begin
 SET NOCOUNT ON;
 
  declare  @cuit nvarchar(50) 
  select @cuit = CUIT_Cliente  from inserted

        update Clientes 
        set Compras_Realizadas=Compras_Realizadas+1
        where CUIT = @cuit
   end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarVentas]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminarProducto]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminardetalleVenta]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[spEliminardetalleCompra]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Trigger [GetTotalVTASIvas]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[GetTotalVTASIvas]
 on [dbo].[Detalle_x_Venta]
 after insert 
 as
  begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from inserted
     update ventas
	 set total_iva= Total+((@cant * @pu)*1.21)
	 where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [GetTotalVTASIva]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[GetTotalVTASIva]
 on [dbo].[Detalle_x_Compra]
 after insert 
 as
  begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from inserted
     update Compras
     set total_iva= Total+((@cant * @pu)*1.21)
     where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [GetTotalVTAS]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[GetTotalVTAS]
 on [dbo].[Detalle_x_Venta]
 after insert 
 as
  begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from inserted
     update ventas
	 set total= Total+(@cant * @pu)
	 where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [GetTotalVTA]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[GetTotalVTA]
 on [dbo].[Detalle_x_Compra]
 after insert 
 as
  begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from inserted
     update Compras
     set total= Total+(@cant * @pu)
     where Nro_factura = @codf
  end
GO
/****** Object:  StoredProcedure [dbo].[cargar_detalle_venta]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  StoredProcedure [dbo].[cargar_detalle_compra]    Script Date: 12/16/2018 17:02:02 ******/
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
/****** Object:  Trigger [AumentarStockDTV]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[AumentarStockDTV]
 on [dbo].[Detalle_x_Venta]
 after delete 
 as
  begin
 SET NOCOUNT ON;
  declare @codart nvarchar(50),@cant int
  select @cant = cantidad , @codart=IdProd from deleted 

        update Productos 
        set Stock=Stock+@cant
        where IdProd = @codart
   end
GO
/****** Object:  Trigger [Agregarstock]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[Agregarstock]
  on [dbo].[Detalle_x_Compra]
  after insert
  AS
  begin set nocount on;
  declare @codart nvarchar(50),@cant int 
  select @cant = cantidad , @codart=IdProd from inserted 

        update Productos 
        set Stock=Stock+@cant
        where IdProd = @codart
   end
GO
/****** Object:  Trigger [Descuento/InteresV]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[Descuento/InteresV]
 on [dbo].[Detalle_x_Venta]
 after insert
 as
 begin
 SET NOCOUNT ON;
 
 declare @Des int, @codf nvarchar(50)
 
 select @Des = Interes, @CodF = inserted.Nro_Factura from inserted
 inner join Ventas on Ventas.Nro_Factura = inserted.Nro_Factura
     update Ventas
     set Total_iva= Total_iva-((total_iva*@Des)/100) 
     where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [Descuento/Interes]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[Descuento/Interes]
 on [dbo].[Detalle_x_Compra]
 after insert
 as
 begin
 SET NOCOUNT ON;
 
 declare @Des int, @codf nvarchar(50)
 
 select @Des = Interes, @CodF = inserted.Nro_Factura from inserted
 inner join Compras on Compras.Nro_Factura = inserted.Nro_Factura
     update Compras
     set Total_iva= Total_iva-((total_iva*@Des)/100) 
     where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [DescontarTotalIVADTV]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[DescontarTotalIVADTV]
 on [dbo].[Detalle_x_Venta]
 after delete 
 as
 begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from deleted
     update Ventas
     set Total_IVA= Total - ((@cant * @pu)*1.21)
     where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [DescontarTotalIVADTC]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[DescontarTotalIVADTC]
 on [dbo].[Detalle_x_Compra]
 after delete 
 as
 begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from deleted
     update Compras
     set Total_IVA= Total - ((@cant * @pu)*1.21)
     where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [DescontarTotalDTC]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[DescontarTotalDTC]
 on [dbo].[Detalle_x_Compra]
 after delete 
 as
 begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from deleted
     update Compras
     set Total= Total-(@cant * @pu)
     where Nro_factura = @codf
  end
GO
/****** Object:  Trigger [DescontarStockDTC]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[DescontarStockDTC]
 on [dbo].[Detalle_x_Compra]
 after delete 
 as
 begin
 SET NOCOUNT ON;
 
  declare @codart nvarchar(50),@cant int 
  select @cant = cantidad , @codart=IdProd from deleted

        update Productos 
        set Stock=Stock-@cant
        where IdProd = @codart
   end
GO
/****** Object:  Trigger [descontarstock]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[descontarstock]
  on [dbo].[Detalle_x_Venta]
  after insert
  AS
  begin set nocount on;
  declare @codart nvarchar(50),@cant int 
  select @cant = cantidad , @codart=IdProd from inserted 
  
		update Productos 
		set Stock=Stock-@cant
		where IdProd = @codart
   end
GO
/****** Object:  Trigger [DescontarPrecioDTV]    Script Date: 12/16/2018 17:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[DescontarPrecioDTV]
 on [dbo].[Detalle_x_Venta]
 after delete 
 as
 begin
 SET NOCOUNT ON;
 
 declare @cant int, @pu money, @codf nvarchar(50)
 
 select @cant = cantidad, @pu = Precio_x_unidad, @CodF = Nro_Factura from deleted
     update Ventas
     set Total= Total-(@cant * @pu)
     where Nro_factura = @codf
  end
GO
/****** Object:  ForeignKey [FK_Compras_Proveedor]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedor] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProv])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedor]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Compra_Compras]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Detalle_x_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Compra_Compras] FOREIGN KEY([Nro_Factura])
REFERENCES [dbo].[Compras] ([Nro_Factura])
GO
ALTER TABLE [dbo].[Detalle_x_Compra] CHECK CONSTRAINT [FK_Detalle_x_Compra_Compras]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Compra_Productos1]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Detalle_x_Compra]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Compra_Productos1] FOREIGN KEY([IdProd])
REFERENCES [dbo].[Productos] ([IdProd])
GO
ALTER TABLE [dbo].[Detalle_x_Compra] CHECK CONSTRAINT [FK_Detalle_x_Compra_Productos1]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Venta_Productos]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Detalle_x_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Venta_Productos] FOREIGN KEY([IdProd])
REFERENCES [dbo].[Productos] ([IdProd])
GO
ALTER TABLE [dbo].[Detalle_x_Venta] CHECK CONSTRAINT [FK_Detalle_x_Venta_Productos]
GO
/****** Object:  ForeignKey [FK_Detalle_x_Venta_Ventas]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Detalle_x_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_x_Venta_Ventas] FOREIGN KEY([Nro_Factura])
REFERENCES [dbo].[Ventas] ([Nro_Factura])
GO
ALTER TABLE [dbo].[Detalle_x_Venta] CHECK CONSTRAINT [FK_Detalle_x_Venta_Ventas]
GO
/****** Object:  ForeignKey [FK_Productos_Categoria1]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categoria1] FOREIGN KEY([IdCat])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categoria1]
GO
/****** Object:  ForeignKey [FK_Ventas_Clientes]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([CUIT_Cliente])
REFERENCES [dbo].[Clientes] ([CUIT])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
/****** Object:  ForeignKey [FK_Ventas_Empleados]    Script Date: 12/16/2018 17:02:02 ******/
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleados]
GO
