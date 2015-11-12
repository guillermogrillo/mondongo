USE [GD2C2015]
GO

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'mondongo')
BEGIN	
	EXEC sp_executesql N'CREATE SCHEMA MONDONGO';
END
GO


IF OBJECT_ID('mondongo.pasajes', 'U') IS NOT NULL
  DROP TABLE mondongo.pasajes;
GO
IF OBJECT_ID('mondongo.paquetes', 'U') IS NOT NULL
  DROP TABLE mondongo.paquetes;
GO
IF OBJECT_ID('mondongo.ventas', 'U') IS NOT NULL
  DROP TABLE mondongo.ventas;
GO
IF OBJECT_ID('mondongo.historial_millas', 'U') IS NOT NULL
  DROP TABLE mondongo.historial_millas;
GO
IF OBJECT_ID('mondongo.productos', 'U') IS NOT NULL
	DROP TABLE mondongo.productos
GO
IF OBJECT_ID('mondongo.clientes', 'U') IS NOT NULL
  DROP TABLE mondongo.clientes;
GO
IF OBJECT_ID('mondongo.usuarios_roles', 'U') IS NOT NULL
  DROP TABLE mondongo.usuarios_roles;
GO
IF OBJECT_ID('mondongo.usuarios', 'U') IS NOT NULL
  DROP TABLE mondongo.usuarios;
GO
IF OBJECT_ID('mondongo.beneficios', 'U') IS NOT NULL
  DROP TABLE mondongo.beneficios;
GO
IF OBJECT_ID('mondongo.tarjeta_credito', 'U') IS NOT NULL
  DROP TABLE mondongo.tarjeta_credito;
GO
IF OBJECT_ID('mondongo.tipos_pago', 'U') IS NOT NULL
  DROP TABLE mondongo.tipos_pago;
GO
IF OBJECT_ID('mondongo.roles_funcionalidades', 'U') IS NOT NULL
  DROP TABLE mondongo.roles_funcionalidades;
GO
IF OBJECT_ID('mondongo.funcionalidades', 'U') IS NOT NULL
  DROP TABLE mondongo.funcionalidades;
GO
IF OBJECT_ID('mondongo.roles', 'U') IS NOT NULL
  DROP TABLE mondongo.roles;
GO
IF OBJECT_ID('mondongo.butacas_vendidas', 'U') IS NOT NULL
  DROP TABLE mondongo.butacas_vendidas;
GO
IF OBJECT_ID('mondongo.viajes', 'U') IS NOT NULL
  DROP TABLE mondongo.viajes;
GO
IF OBJECT_ID('mondongo.rutas', 'U') IS NOT NULL
  DROP TABLE mondongo.rutas;
GO
IF OBJECT_ID('mondongo.tipos_servicio', 'U') IS NOT NULL
  DROP TABLE mondongo.tipos_servicio;
GO
IF OBJECT_ID('mondongo.ciudades', 'U') IS NOT NULL
  DROP TABLE mondongo.ciudades;
GO
IF OBJECT_ID('mondongo.aeronaves', 'U') IS NOT NULL
  DROP TABLE mondongo.aeronaves;
GO
IF OBJECT_ID('mondongo.fabricantes', 'U') IS NOT NULL
  DROP TABLE mondongo.fabricantes;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_ciudades', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_ciudades;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_clientes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_clientes;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_tipos_servicio', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_tipos_servicio;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_butacas', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_butacas;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_fabricantes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_fabricantes;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_roles', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_roles;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_funcionalidades', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_funcionalidades;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_roles_funcionalidades', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_roles_funcionalidades;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_usuarios', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_usuarios;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_tipos_pago', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_tipos_pago;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_tarjetas_credito', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_tarjetas_credito;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_beneficios', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_beneficios;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_aeronaves', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_aeronaves;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_rutas', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_rutas;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_ventas', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_ventas;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_pasajes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_pasajes;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_paquetes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_paquetes;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_viajes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_viajes;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_usuarios_roles', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_usuarios_roles;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_productos', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_productos;
GO
IF OBJECT_ID('MONDONGO.pr_cargar_butacas_vendidas', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_butacas_vendidas;
GO
IF OBJECT_ID('MONDONGO.pr_actualizar_viajes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_actualizar_viajes;
GO
IF OBJECT_ID('MONDONGO.fx_get_tipo_servicio', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_get_tipo_servicio;
GO
IF OBJECT_ID('MONDONGO.fx_cantidad_butacas', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_cantidad_butacas;
GO
IF OBJECT_ID('MONDONGO.fx_busca_id_fabricante', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_id_fabricante;
GO
IF OBJECT_ID('MONDONGO.fx_busca_id_tipo_servicio', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_id_tipo_servicio;
GO
IF OBJECT_ID('MONDONGO.fx_cantidad_kg_aeronave', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_cantidad_kg_aeronave;
GO
IF OBJECT_ID('MONDONGO.fx_busca_id_cliente', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_id_cliente;
GO
IF OBJECT_ID('MONDONGO.fx_busca_id_ruta', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_id_ruta;
GO
IF OBJECT_ID('MONDONGO.fx_busca_id_ciudad', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_id_ciudad;
GO
IF OBJECT_ID('MONDONGO.fx_busca_id_viaje', 'FN') IS NOT NULL
    drop function mondongo.fx_busca_id_viaje;
go
IF OBJECT_ID('MONDONGO.fx_busca_butacas_pasillo_disponibles', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_butacas_pasillo_disponibles;
GO
IF OBJECT_ID('MONDONGO.fx_busca_butacas_ventanilla_disponibles', 'FN') IS NOT NULL
  DROP FUNCTION mondongo.fx_busca_butacas_ventanilla_disponibles;
GO
IF OBJECT_ID('MONDONGO.fx_busca_kg_disponibles', 'FN') IS NOT NULL
    drop function mondongo.fx_busca_kg_disponibles;
go
IF EXISTS (SELECT * FROM sys.sequences seq JOIN sys.schemas sch ON seq.schema_id=sch.schema_id WHERE seq.name=N'sq_pnr'  AND sch.name=N'mondongo' )
   DROP SEQUENCE mondongo.sq_pnr
GO


create function mondongo.fx_busca_id_tipo_servicio(@tipo_servicio nvarchar(255))
returns numeric(18,0)
as
begin
    declare @ID_TIPO_SERVICIO numeric(18,0)
    set @ID_TIPO_SERVICIO = (select id_tipo_servicio from MONDONGO.tipos_servicio where upper(tipo_servicio)=upper(@tipo_servicio))
    return @ID_TIPO_SERVICIO
end
GO
create function MONDONGO.fx_cantidad_butacas(@aeronave_matricula nvarchar(255), @butaca_tipo nvarchar(255))
returns numeric(18,0)
as begin    
    declare @CANT_BUTACAS numeric(18,0)
    SET @CANT_BUTACAS = (select max(cant_butacas)
                from (
                    select Aeronave_Matricula, Pasaje_FechaCompra, count(*) cant_butacas
                    from gd_esquema.Maestra
                    where Pasaje_FechaCompra > '01/01/2000'
                        and Aeronave_Matricula=@aeronave_matricula
                        and Butaca_Tipo=@butaca_tipo
                    group by Aeronave_Matricula, Pasaje_FechaCompra
                ) as a
                group by Aeronave_Matricula
                )
    return @CANT_BUTACAS
end
GO
create function mondongo.fx_busca_id_fabricante(@fabricante nvarchar(255))
returns numeric(18,0)
as
begin
    declare @ID_FABRICANTE numeric(18,0)
    set @ID_FABRICANTE = (select id_fabricante from MONDONGO.fabricantes where upper(nombre)=upper(@fabricante))
    return @ID_FABRICANTE
end
GO
create function mondongo.fx_cantidad_kg_aeronave(@matricula nvarchar(255))
returns numeric(18,0)
as begin
    declare @KG_DISPONIBLES numeric(18,0)
    set @KG_DISPONIBLES = (select top 1 aeronave_kg_disponibles
                         from gd_esquema.Maestra
                         where aeronave_matricula=@matricula)
    return @KG_DISPONIBLES
end
GO
create function mondongo.fx_busca_id_cliente(@cliente_dni numeric(18,0), @apellido nvarchar(255))
returns numeric(18,0)
as
begin
    declare @CLIENTE_ID numeric(18,0)
    set @CLIENTE_ID = (
        select cliente_id
        from mondongo.clientes
        where cliente_dni = @cliente_dni
        and cliente_apellido = @apellido
    )
    return @CLIENTE_ID
end
GO
create function mondongo.fx_busca_id_ruta(@origen nvarchar(255),@destino nvarchar(255),@tipo_servicio nvarchar(255))
returns numeric(18,0)
as
begin
    declare @ID_RUTA numeric(18,0)
    declare @ID_CIUDAD_ORIGEN numeric(18,0)
    declare @ID_CIUDAD_DESTINO numeric(18,0)
    declare @ID_TIPO_SERVICIO numeric(18,0)

    set @ID_CIUDAD_ORIGEN = (select id_ciudad from mondongo.ciudades where upper(nombre) = upper(@origen))
    set @ID_CIUDAD_DESTINO = (select id_ciudad from mondongo.ciudades where upper(nombre) = upper(@destino))
    set @ID_TIPO_SERVICIO = (select id_tipo_servicio from mondongo.tipos_servicio where upper(tipo_servicio) = upper(@tipo_servicio))

    set @ID_RUTA = (select id_ruta from MONDONGO.rutas
                    where id_tipo_servicio=@ID_TIPO_SERVICIO
                        and id_ciudad_origen = @ID_CIUDAD_ORIGEN
                        and id_ciudad_destino = @ID_CIUDAD_DESTINO)
    return @ID_RUTA
end
GO
create function [MONDONGO].[fx_busca_id_ciudad](@ciudad_nombre nvarchar(255))
returns numeric(18,0)
as
begin
    declare @ID_CIUDAD numeric(18,0)
    set @ID_CIUDAD = (select id_ciudad from MONDONGO.ciudades where upper(nombre)=upper(@ciudad_nombre))
    return @ID_CIUDAD
end
GO
create function mondongo.fx_busca_id_viaje(@ciudad_desde nvarchar(255),@ciudad_hasta nvarchar(255),@fecha_llegada datetime, @aeronave_matricula nvarchar(255), @tipo_servicio nvarchar(255))
returns numeric(18,0)
as
begin
    declare @ID_VIAJE numeric(18,0)
    declare @ID_RUTA numeric(18,0)
    set @ID_RUTA = mondongo.fx_busca_id_ruta(@ciudad_desde,@ciudad_hasta,@tipo_servicio)
    set @ID_VIAJE = (select viaje_id from MONDONGO.viajes where viaje_ruta_id = @ID_RUTA and aeronave_matricula = @aeronave_matricula and fecha_llegada = @fecha_llegada)
    return @ID_VIAJE
end
go
create function mondongo.fx_busca_butacas_pasillo_disponibles(@matricula nvarchar(255))
returns numeric(18,0)
as
begin
    declare @CANT_PASAJES numeric(18,0)
    set @CANT_PASAJES = (select cantidad_butacas_pas from mondongo.aeronaves where matricula = @matricula)
    return @CANT_PASAJES
end
go
create function mondongo.fx_busca_butacas_ventanilla_disponibles(@matricula nvarchar(255))
returns numeric(18,0)
as
begin
    declare @CANT_PASAJES numeric(18,0)
    set @CANT_PASAJES = (select  cantidad_butacas_ven from mondongo.aeronaves where matricula = @matricula)
    return @CANT_PASAJES
end
go
create function mondongo.fx_busca_kg_disponibles(@matricula nvarchar(255))
returns numeric(18,0)
as
begin
    declare @CANT_KG numeric(18,0)
    set @CANT_KG = (select capacidad_kg from mondongo.aeronaves where matricula = @matricula)
    return @CANT_KG
end
go
CREATE PROCEDURE mondongo.pr_cargar_tipos_servicio
AS
BEGIN
    INSERT INTO MONDONGO.tipos_servicio(tipo_servicio)
    SELECT distinct Tipo_Servicio from gd_esquema.Maestra;
END
GO
CREATE PROCEDURE mondongo.pr_cargar_ciudades
AS
BEGIN
    INSERT INTO MONDONGO.ciudades(nombre)
    SELECT distinct RIGHT(Ruta_Ciudad_Origen, LEN(Ruta_Ciudad_Origen) - 1) from gd_esquema.Maestra;
END
GO
create procedure mondongo.pr_cargar_butacas(@cantida_butacas numeric(4,0), @matricula numeric(18,0))
as begin
DECLARE @I INT, @TIPO_BUTACA nvarchar(15)
SET @I = 1

    WHILE @I <= @cantida_butacas
    BEGIN
        IF @I % 2 = 0
            set @TIPO_BUTACA = 'Ventanilla'
        ELSE
            set @TIPO_BUTACA = 'Pasillo'

        INSERT INTO mondongo.butacas(aeronave_matricula, butaca_nro, butaca_piso, butaca_tipo)
        VALUES(@matricula, @I, 1, @TIPO_BUTACA)

        SET @I = @I + 1
    END
END
GO
CREATE PROCEDURE mondongo.pr_cargar_fabricantes
AS
BEGIN
    INSERT INTO MONDONGO.fabricantes(nombre)
    SELECT distinct Aeronave_Fabricante from gd_esquema.Maestra;
END
GO
CREATE PROCEDURE mondongo.pr_cargar_clientes
AS
BEGIN
    PRINT 'COMIENZA MIGRACION DE CLIENTES'    
    insert into mondongo.clientes(cliente_nombre,cliente_apellido,cliente_dni,cliente_direccion,cliente_telefono,cliente_mail,cliente_fecha_nacimiento,rol_id)
    select distinct cli_nombre,cli_apellido,cli_dni,cli_dir,cli_telefono,cli_mail,cli_fecha_nac,2 from gd_esquema.Maestra m    
    PRINT 'FINALIZA MIGRACION DE CLIENTES'
END
GO
CREATE PROCEDURE mondongo.pr_cargar_roles
AS
    BEGIN
        PRINT 'COMIENZA LA MIGRACION DE ROLES...'
        insert mondongo.roles values ('administrador',1)
        insert mondongo.roles values ('cliente',1)        
        PRINT '...FINALIZA LA MIGRACION DE ROLES'
    END
GO
CREATE PROCEDURE mondongo.pr_cargar_funcionalidades
AS
    BEGIN
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('ABM de Rol','ABM de Rol')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('ABM de Ruta Aerea','ABM de Ruta Aerea')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('ABM de Aeronave','ABM de Aeronave')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Generacion de Viaje','Generacion de Viaje')    
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Registro de llegada a Destino','Registro de llegada a Destino')
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Compra de pasaje/encomienda','Compra de pasaje/encomienda')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Devolucion/Cancelacion de pasaje y/o encomienda','Devolucion/Cancelacion de pasaje y/o encomienda')                 
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Consulta de millas de pasajero frecuente','Consulta de millas de pasajero frecuente')  
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Canje de millas','Canje de millas')    
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('Listado Estadistico','Listado Estadistico')
    END
GO
CREATE PROCEDURE mondongo.pr_cargar_roles_funcionalidades
AS
    BEGIN        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,1)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,2)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,3)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,4)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,5)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,6)
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,7)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,8)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,9)
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(1,10)
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(2,6)
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(2,7)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(2,8)        
        insert into mondongo.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) values(2,9)
    END
GO
CREATE PROCEDURE mondongo.pr_cargar_usuarios
AS
    BEGIN        
        insert into MONDONGO.USUARIOS(usuario_nombre,usuario_contraseņa) values ('adminUno','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
        insert into MONDONGO.USUARIOS(usuario_nombre,usuario_contraseņa)    values ('adminDos','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')    
    END
GO
create procedure mondongo.pr_cargar_usuarios_roles
as
begin
    insert into mondongo.usuarios_roles(usuario_id,rol_id) values (1,1)
    insert into mondongo.usuarios_roles(usuario_id,rol_id) values (2,1)
end
go
CREATE PROCEDURE mondongo.pr_cargar_tipos_pago
AS
    BEGIN        
        insert into mondongo.tipos_pago values ('EFECTIVO')
        insert into mondongo.tipos_pago values ('TARJETA')    
    END
GO
CREATE PROCEDURE mondongo.pr_cargar_tarjetas_credito
AS
    BEGIN        
        insert into mondongo.tarjeta_credito values('VISA',2)
        insert into mondongo.tarjeta_credito values('AMERICAN EXPRESS',2)
        insert into mondongo.tarjeta_credito values('MASTERCARD',2)
        insert into mondongo.tarjeta_credito values('MAESTRO',2)
        insert into mondongo.tarjeta_credito values('CABAL',2)
    END
GO
CREATE PROCEDURE mondongo.pr_cargar_beneficios
AS
    BEGIN        
        insert into mondongo.beneficios values ('VISA-6 PAGOS',6,1)
        insert into mondongo.beneficios values ('VISA-12 PAGOS',12,1)
        insert into mondongo.beneficios values ('AMERICAN EXPRESS-6 PAGOS',6,2)
        insert into mondongo.beneficios values ('AMERICAN EXPRESS-12 PAGOS',12,2)
        insert into mondongo.beneficios values ('AMERICAN EXPRESS-18 PAGOS',18,2)
        insert into mondongo.beneficios values ('MASTERCARD-6 PAGOS',6,3)
        insert into mondongo.beneficios values ('MASTERCARD-12 PAGOS',12,3)
        insert into mondongo.beneficios values ('MAESTRO-6 PAGOS',6,4)
        insert into mondongo.beneficios values ('CABAL-12 PAGOS',12,5)    
    END
GO
CREATE PROCEDURE [MONDONGO].[pr_cargar_aeronaves]
AS
BEGIN
    INSERT INTO MONDONGO.aeronaves(matricula, modelo, capacidad_kg, id_fabricante, id_tipo_servicio, fecha_alta,
                                    cantidad_butacas_pas,cantidad_butacas_ven)
    SELECT Aeronave_Matricula,
            Aeronave_Modelo,
            MONDONGO.fx_cantidad_kg_aeronave(Aeronave_Matricula),
            MONDONGO.fx_busca_id_fabricante(aeronave_fabricante),
            MONDONGO.fx_busca_id_tipo_servicio(Tipo_Servicio),
            sysdatetime(),
            MONDONGO.fx_cantidad_butacas(Aeronave_Matricula, 'Pasillo'),
            MONDONGO.fx_cantidad_butacas(Aeronave_Matricula, 'Ventanilla')
    from gd_esquema.Maestra
    group by Aeronave_Matricula, Aeronave_Modelo, aeronave_fabricante, Tipo_Servicio
END
GO
CREATE PROCEDURE [MONDONGO].[pr_cargar_rutas]
AS
BEGIN
    insert into MONDONGO.rutas(codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, precio_base_pasaje, precio_base_kg, horas_vuelo)
    select ruta_codigo,
        mondongo.fx_busca_id_ciudad(RIGHT(Ruta_Ciudad_Origen, LEN(Ruta_Ciudad_Origen) - 1)),
        mondongo.fx_busca_id_ciudad(RIGHT(Ruta_Ciudad_Destino, LEN(Ruta_Ciudad_Destino) - 1)),
        mondongo.fx_busca_id_tipo_servicio(Tipo_Servicio),
        max(Ruta_Precio_BasePasaje),
        max(Ruta_Precio_BaseKG),
        datediff(hh, FechaSalida,FechaLLegada)
    from gd_esquema.Maestra
    group by ruta_codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, tipo_servicio, datediff(hh, FechaSalida,FechaLLegada)
    order by Ruta_Ciudad_Origen
END
GO
create PROCEDURE [MONDONGO].[pr_cargar_pasajes]
AS
BEGIN
    insert into mondongo.pasajes(pasaje_pnr,pasaje_pasajero_id,pasaje_pagador_id,pasaje_monto,pasaje_viaje_id,pasaje_fecha_compra,pasaje_tipo_pago_id,pasaje_butaca_tipo,pasaje_butaca_numero,estado)
    select      Pasaje_Codigo as pasaje_pnr,
                mondongo.fx_busca_id_cliente(cli_dni, Cli_Apellido) as pasaje_pasajero_id,
                mondongo.fx_busca_id_cliente(cli_dni, Cli_Apellido) as pasaje_pagador_id,
                Pasaje_Precio as pasaje_monto,                
                mondongo.fx_busca_id_viaje(RIGHT(Ruta_Ciudad_Origen, LEN(Ruta_Ciudad_Origen) - 1),RIGHT(Ruta_Ciudad_Destino, LEN(Ruta_Ciudad_Destino) - 1),FechaLLegada,Aeronave_Matricula,Tipo_Servicio) as pasaje_viaje_id,
                Pasaje_FechaCompra as pasaje_fecha_compra,
                1 as tipo_pago_id,
                Butaca_Tipo,
                Butaca_Nro,
				0
    from        gd_esquema.Maestra
    where        Pasaje_Codigo <> 0
END
GO
CREATE PROCEDURE [MONDONGO].[pr_cargar_paquetes]
AS
BEGIN
    insert into mondongo.paquetes(paquete_pnr,paquete_viaje_id,paquete_kg, paquete_monto, paquete_pagador_id,paquete_fecha_compra,paquete_tipo_pago_id,estado)
    select        m.Paquete_Codigo,
                mondongo.fx_busca_id_viaje(RIGHT(Ruta_Ciudad_Origen, LEN(Ruta_Ciudad_Origen) - 1),RIGHT(Ruta_Ciudad_Destino, LEN(Ruta_Ciudad_Destino) - 1),FechaLLegada,Aeronave_Matricula,Tipo_Servicio),
                m.Paquete_KG,
                m.Paquete_Precio,
                mondongo.fx_busca_id_cliente(cli_dni, Cli_Apellido),
                Paquete_FechaCompra as pasaje_fecha_compra,
                1 as tipo_pago_id,
				0
    from    gd_esquema.Maestra m
    where    m.Paquete_Codigo <>0
END
go
CREATE PROCEDURE mondongo.pr_cargar_viajes
as
begin
    insert into mondongo.viajes(aeronave_matricula,viaje_ruta_id, fecha_salida, fecha_llegada, fecha_llegada_estimada, cantidad_butacas_ventanilla_disponibles, cantidad_butacas_pasillo_disponibles, cantidad_kg_disponibles,estado)
    select  m.Aeronave_Matricula,
            mondongo.fx_busca_id_ruta(RIGHT(m.Ruta_Ciudad_Origen, LEN(m.Ruta_Ciudad_Origen) - 1), RIGHT(m.Ruta_Ciudad_Destino, LEN(m.Ruta_Ciudad_Destino) - 1), m.Tipo_Servicio) as viaje_ruta_id,
            m.FechaSalida,
            m.FechaLLegada,
            m.Fecha_LLegada_Estimada,
            mondongo.fx_busca_butacas_ventanilla_disponibles(m.Aeronave_Matricula),
            mondongo.fx_busca_butacas_pasillo_disponibles(m.Aeronave_Matricula),
            mondongo.fx_busca_kg_disponibles(m.Aeronave_Matricula),
			0
    from gd_esquema.Maestra m
    group by m.Ruta_Ciudad_Origen,m.Ruta_Ciudad_Destino, m.Tipo_Servicio, m.FechaSalida, m.FechaLLegada,m.Fecha_LLegada_Estimada, m.Aeronave_Matricula;
end
go
CREATE PROCEDURE mondongo.pr_cargar_productos
AS
    BEGIN        
        insert into mondongo.productos(stock, descripcion, costo_millas) values (15,'LICUADORA',150)
		insert into mondongo.productos(stock, descripcion, costo_millas) values (15,'PELOTA',75)
		insert into mondongo.productos(stock, descripcion, costo_millas) values (15,'COLCHON INFLABLE',250)
		insert into mondongo.productos(stock, descripcion, costo_millas) values (15,'CARPA',325)
		insert into mondongo.productos(stock, descripcion, costo_millas) values (15,'6 VASOS',100)        
    END
GO

create procedure mondongo.pr_cargar_butacas_vendidas
as
begin
    insert into mondongo.butacas_vendidas(butaca_viaje_id,butaca_tipo,butaca_nro)
    select pasaje_viaje_id,pasaje_butaca_tipo,pasaje_butaca_numero
    from mondongo.pasajes
end
go
create procedure mondongo.pr_actualizar_viajes
as
begin
	update mondongo.viajes
	set cantidad_butacas_ventanilla_disponibles = cantidad_butacas_ventanilla_disponibles - b.cantidad
	from mondongo.viajes v
	inner join (select butaca_viaje_id, count(butaca_viaje_id) as cantidad
				from mondongo.butacas_vendidas bv
				group by bv.butaca_viaje_id, bv.butaca_tipo
				having bv.butaca_tipo = 'Ventanilla') b
	on b.butaca_viaje_id = v.viaje_id

	update mondongo.viajes
	set cantidad_butacas_ventanilla_disponibles = cantidad_butacas_ventanilla_disponibles - b.cantidad
	from mondongo.viajes v
	inner join (select butaca_viaje_id, count(butaca_viaje_id) as cantidad
				from mondongo.butacas_vendidas bv
				group by bv.butaca_viaje_id, bv.butaca_tipo
				having bv.butaca_tipo = 'Pasillo') b
	on b.butaca_viaje_id = v.viaje_id
end
go
create table mondongo.roles
(rol_id numeric(18,0) identity primary key,
rol_nombre nvarchar(20) not null,
rol_habilitado int not null default 1
)
GO
create table mondongo.usuarios
(usuario_id numeric(18,0) primary key identity,
usuario_nombre nvarchar(20) not null,
usuario_contraseņa nvarchar(255) not null,
usuario_intentos_fallidos int default 0,
usuario_bloqueado int default 0
)
GO
create table mondongo.usuarios_roles
(
usuario_id numeric(18,0) references mondongo.usuarios(usuario_id),
rol_id numeric(18,0) references mondongo.roles(rol_id)
)
go
CREATE TABLE mondongo.funcionalidades
(funcionalidad_id numeric(18,0) identity primary key ,
funcionalidad_nombre nvarchar(100) not null,
funcionalidad_descripcion nvarchar(100) not null
)
GO

CREATE TABLE mondongo.roles_funcionalidades
(rol_id numeric(18,0) references mondongo.roles(rol_id),
funcionalidad_id numeric(18,0) references mondongo.funcionalidades(funcionalidad_id)
)
GO
create table mondongo.tipos_pago(
tipo_pago_id numeric(18,0) primary key identity,
descripcion nvarchar(255) not null
)
GO
create table mondongo.tarjeta_credito
(
tarjeta_credito_id numeric(18,0) identity primary key,
tarjeta_credito_descripcion nvarchar(255) not null,
tarjeta_credito_tipo_pago_id numeric(18,0) references mondongo.tipos_pago(tipo_pago_id)
)
GO
create table mondongo.beneficios
(
beneficio_id numeric(18,0) primary key identity,
beneficio_descripcion nvarchar(255),
beneficio_cantidad_cuotas numeric(2),
beneficio_tarjeta_credito numeric(18,0) references mondongo.tarjeta_credito(tarjeta_credito_id)
)
GO
CREATE TABLE mondongo.clientes
(cliente_id numeric(18,0) primary key identity,
cliente_nombre nvarchar(255) not null,
cliente_apellido nvarchar(255) not null,
cliente_dni numeric(18,0) not null,
cliente_direccion nvarchar(255) null,
cliente_telefono numeric(18,0) null,
cliente_mail nvarchar(255) not null,
cliente_fecha_nacimiento datetime null,
rol_id numeric(18,0) not null references mondongo.roles(rol_id)
)
GO
CREATE TABLE [MONDONGO].[ciudades](
    [id_ciudad] [numeric](18,0) identity primary key,
    [nombre] [nvarchar](255) NULL,
) ON [PRIMARY]
GO
create table mondongo.tipos_servicio(
    id_tipo_servicio numeric(8) primary key identity,
    tipo_servicio nvarchar(255)
)
GO
create table MONDONGO.rutas(
    id_ruta numeric(18) primary key identity,
    codigo_ruta numeric(18) not null,
    id_ciudad_origen numeric(18,0) not null REFERENCES mondongo.ciudades(id_ciudad),
    id_ciudad_destino numeric(18,0) not null REFERENCES mondongo.ciudades(id_ciudad),
    id_tipo_servicio numeric(8) REFERENCES mondongo.tipos_servicio(id_tipo_servicio),
    precio_base_kg numeric(18,2),
    precio_base_pasaje numeric(18,2),
[horas_vuelo] [numeric](18, 0) NULL
)
GO
CREATE TABLE MONDONGO.fabricantes(
    id_fabricante numeric(18,0) identity primary key,
    nombre nvarchar(255) not null
)
GO
CREATE TABLE [MONDONGO].[aeronaves](
    [matricula] [nvarchar](255) NOT NULL primary key,
    [modelo] [nvarchar](255) NULL,
    [capacidad_kg] [numeric](18, 0) NULL,
    [id_fabricante] [numeric](18, 0) NULL REFERENCES mondongo.fabricantes(id_fabricante),
    [id_tipo_servicio] [numeric](18, 0) NULL,
    [fecha_alta] [date] NULL,
    [fecha_fuera_servicio] [date] NULL,
    [fecha_reinicio_servicio] [date] NULL,
    [cantidad_butacas_ven] [numeric](18, 0) NULL,
    [cantidad_butacas_pas] [numeric](18, 0) NULL,
    [fecha_baja_definitiva] [date] NULL,
[estado] [numeric](18,0)
) ON [PRIMARY]
GO
create table mondongo.viajes(
    viaje_id numeric(18,0) identity primary key,
    viaje_ruta_id numeric(18) references mondongo.rutas(id_ruta),
    aeronave_matricula nvarchar(255) references mondongo.aeronaves(matricula),
    fecha_salida datetime not null,
    fecha_llegada datetime,
    fecha_llegada_estimada datetime not null,
        cantidad_butacas_ventanilla_disponibles numeric(18,0) not null,
cantidad_butacas_pasillo_disponibles numeric(18,0) not null,
cantidad_kg_disponibles numeric(18,0) not null,
estado numeric(1,0)
)
GO
create table mondongo.pasajes(
pasaje_id numeric(18,0) primary key identity,
pasaje_pnr numeric(18,0) not null,
pasaje_pasajero_id numeric(18,0) references mondongo.clientes(cliente_id),
pasaje_pagador_id numeric(18,0) references mondongo.clientes(cliente_id),
pasaje_viaje_id numeric(18,0) references mondongo.viajes(viaje_id),
pasaje_monto numeric(18,2) default 0,
pasaje_fecha_compra datetime default getdate(),
pasaje_tipo_pago_id numeric(18,0) references mondongo.tipos_pago(tipo_pago_id),
pasaje_butaca_tipo varchar(255) not null,
pasaje_butaca_numero numeric(18,0) not null,
estado numeric(1,0)
)
GO
create table mondongo.paquetes(
paquete_id numeric(18,0) primary key identity,
paquete_pnr numeric(18,0) not null,
paquete_kg numeric(18,0) default 0,
paquete_monto numeric(18,2) default 0,
paquete_viaje_id numeric(18,0) references mondongo.viajes(viaje_id),
paquete_pagador_id numeric(18,0) references mondongo.clientes(cliente_id),
paquete_fecha_compra datetime default getdate(),
paquete_tipo_pago_id numeric(18,0) references mondongo.tipos_pago(tipo_pago_id),
estado numeric(1,0)
)
GO
CREATE TABLE MONDONGO.butacas_vendidas(    
    butaca_nro numeric(18, 0) NOT NULL,
    butaca_tipo nvarchar(255) NOT NULL,
    butaca_viaje_id numeric (18,0) NOT NULL references mondongo.viajes(viaje_id)       
)
GO
ALTER TABLE MONDONGO.butacas_vendidas
ADD CONSTRAINT PK_BUTACAS_VENDIDAS
PRIMARY KEY (butaca_nro, butaca_tipo, butaca_viaje_id)
GO


create table mondongo.productos(
	id_producto numeric(18,0) primary key identity,
	stock numeric(3,0) not null,
	descripcion nvarchar(255) not null,
	costo_millas numeric(7,0) not null
)
GO

create table mondongo.historial_millas(
	id_historial numeric(18,0) primary key identity,
	id_cliente numeric(18,0) not null references mondongo.clientes(cliente_id),
	id_viaje numeric(18,0) null references mondongo.viajes(viaje_id),
	id_producto numeric(18,0) null references mondongo.productos(id_producto),
	cantidad_producto numeric(3,0) null,
	cantidad_millas numeric(7,0) not null,
	fecha_operacion datetime default getdate(),
	tipo_operacion char not null
)
GO



IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.maestra') AND NAME ='maestra_pas_cod')
    DROP INDEX gd_esquema.maestra.maestra_pas_cod
GO
	CREATE INDEX maestra_pas_cod ON gd_esquema.maestra (pasaje_codigo)
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.maestra') AND NAME ='maestra_paq_cod')
    DROP INDEX gd_esquema.maestra.maestra_paq_cod
GO
	CREATE INDEX maestra_paq_cod ON gd_esquema.maestra (paquete_codigo)
GO

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('gd_esquema.maestra') AND NAME ='maestra_matricula')
    DROP INDEX gd_esquema.maestra.maestra_matricula
GO
	CREATE INDEX maestra_matricula ON gd_esquema.maestra (aeronave_matricula)
GO
CREATE INDEX index_ruta_ciu_orig
ON mondongo.rutas (id_ciudad_origen)
GO
CREATE INDEX index_ruta_ciu_dest
ON mondongo.rutas (id_ciudad_destino)
GO
CREATE INDEX index_viaje_ruta
ON mondongo.viajes (viaje_ruta_id)
GO
CREATE INDEX index_ruta_matricula
ON mondongo.viajes (aeronave_matricula)
GO
create trigger tr_restar_kg
on mondongo.paquetes
after insert
as
begin

    BEGIN TRY
        update mondongo.viajes
        set cantidad_kg_disponibles = cantidad_kg_disponibles - (select SUM(inserted.paquete_kg)
                                                                from inserted
                                                                where viajes.viaje_id = inserted.paquete_viaje_id
                                                                group by inserted.paquete_viaje_id)
    END TRY
    BEGIN CATCH
        SELECT
        ERROR_NUMBER() AS ErrorNumber
       ,ERROR_MESSAGE() AS ErrorMessage;       
    END CATCH;
    
end
go

create sequence mondongo.sq_pnr as int
	START WITH 79435967
	INCREMENT BY 1 ;
go
exec mondongo.pr_cargar_productos
go
exec mondongo.pr_cargar_funcionalidades
go
exec mondongo.pr_cargar_roles
go
exec mondongo.pr_cargar_roles_funcionalidades
go
exec mondongo.pr_cargar_usuarios
go
exec mondongo.pr_cargar_usuarios_roles
go
exec mondongo.pr_cargar_clientes
go
exec mondongo.pr_cargar_tipos_pago
go
exec mondongo.pr_cargar_tarjetas_credito
go
exec mondongo.pr_cargar_beneficios
go
exec mondongo.pr_cargar_fabricantes
go
exec mondongo.pr_cargar_tipos_servicio
go
exec mondongo.pr_cargar_aeronaves
go
exec mondongo.pr_cargar_ciudades
go
exec mondongo.pr_cargar_rutas
go
exec mondongo.pr_cargar_viajes
go
exec mondongo.pr_cargar_pasajes
go
exec mondongo.pr_cargar_paquetes
go
exec mondongo.pr_cargar_butacas_vendidas
go
exec mondongo.pr_actualizar_viajes
go