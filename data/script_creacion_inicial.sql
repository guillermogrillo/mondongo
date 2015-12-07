USE [GD2C2015]
GO

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'mondongo')
BEGIN	
	EXEC sp_executesql N'CREATE SCHEMA MONDONGO';
END
GO

IF OBJECT_ID('mondongo.devoluciones_pasajes', 'U') IS NOT NULL
  DROP TABLE mondongo.devoluciones_pasajes;
GO
IF OBJECT_ID('mondongo.devoluciones_paquetes', 'U') IS NOT NULL
  DROP TABLE mondongo.devoluciones_paquetes;
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
IF OBJECT_ID('mondongo.canje_millas', 'U') IS NOT NULL
  DROP TABLE mondongo.canje_millas;
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
IF OBJECT_ID('mondongo.butacas_viaje', 'U') IS NOT NULL
  DROP TABLE mondongo.butacas_viaje;
GO
IF OBJECT_ID('mondongo.viajes', 'U') IS NOT NULL
  DROP TABLE mondongo.viajes;
GO
IF OBJECT_ID('mondongo.ruta_tipo_servicio', 'U') IS NOT NULL
  DROP TABLE mondongo.ruta_tipo_servicio;
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
IF OBJECT_ID('mondongo.butacas', 'U') IS NOT NULL
  DROP TABLE mondongo.butacas;
GO
IF OBJECT_ID('mondongo.aeronaves_bajas', 'U') IS NOT NULL
  DROP TABLE mondongo.aeronaves_bajas;
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
IF OBJECT_ID('MONDONGO.pr_cargar_butacas_viaje', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_butacas_viaje;
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
IF OBJECT_ID('MONDONGO.pr_cargar_ruta_tipo_servicio', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_cargar_ruta_tipo_servicio;
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
IF OBJECT_ID('MONDONGO.pr_actualizar_viajes', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_actualizar_viajes;
GO
IF OBJECT_ID('MONDONGO.pr_generar_butacas', 'P') IS NOT NULL
  DROP PROCEDURE mondongo.pr_generar_butacas;
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
    SET @CANT_BUTACAS = (select count (distinct Butaca_Nro) as cant_butacas
						from gd_esquema.Maestra
						where Aeronave_Matricula=@aeronave_matricula
						and Butaca_Tipo=@butaca_tipo)
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
create function mondongo.fx_busca_id_viaje(@ciudad_desde nvarchar(255),@ciudad_hasta nvarchar(255),@fecha_salida datetime, @aeronave_matricula nvarchar(255), @tipo_servicio nvarchar(255))
returns numeric(18,0)
as
begin
    declare @ID_VIAJE numeric(18,0)
    declare @ID_RUTA numeric(18,0)
    set @ID_RUTA = mondongo.fx_busca_id_ruta(@ciudad_desde,@ciudad_hasta,@tipo_servicio)
    set @ID_VIAJE = (select viaje_id from MONDONGO.viajes where viaje_ruta_id = @ID_RUTA and aeronave_matricula = @aeronave_matricula and fecha_salida = @fecha_salida)
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
    INSERT INTO MONDONGO.tipos_servicio(tipo_servicio, costo_adicional)
    SELECT distinct upper(Tipo_Servicio),
	case tipo_servicio when 'EJECUTIVO' then 50
						when 'PRIMERA CLASE' then 100
						else 0
	end
	from gd_esquema.Maestra;
END
GO
CREATE PROCEDURE mondongo.pr_cargar_ciudades
AS
BEGIN
    INSERT INTO MONDONGO.ciudades(nombre)
    SELECT distinct RIGHT(upper(Ruta_Ciudad_Origen), LEN(Ruta_Ciudad_Origen) - 1) from gd_esquema.Maestra;
END
GO

CREATE PROCEDURE mondongo.pr_cargar_fabricantes
AS
BEGIN
    INSERT INTO MONDONGO.fabricantes(nombre)
    SELECT distinct upper(Aeronave_Fabricante) from gd_esquema.Maestra;
END
GO
CREATE PROCEDURE mondongo.pr_cargar_clientes
AS
BEGIN    
    insert into mondongo.clientes(cliente_nombre,cliente_apellido,cliente_dni,cliente_direccion,cliente_telefono,cliente_mail,cliente_fecha_nacimiento,rol_id)
    select distinct upper(cli_nombre),upper(cli_apellido),cli_dni,upper(cli_dir),cli_telefono,upper(cli_mail),cli_fecha_nac,2 from gd_esquema.Maestra m        
END
GO
CREATE PROCEDURE mondongo.pr_cargar_roles
AS
    BEGIN        
        insert mondongo.roles values ('ADMINISTRADOR',1)
        insert mondongo.roles values ('CLIENTE',1)                
    END
GO
CREATE PROCEDURE mondongo.pr_cargar_funcionalidades
AS
    BEGIN
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnABMRol','ABM DE ROL')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnABMRutaAerea','ABM DE RUTA AEREA')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnABMAeronaves','ABM DE AERONAVE')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnGenerarViaje','GENERACION DE VIAJE')    
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnRegistrarLlegada','REGISTRO DE LLEGADA A DESTINO')
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnComprarPasajes','COMPRA DE PASAJE/ENCOMIENDA')        
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnCancelarPasajes','DEVOLUCION/CANCELACION DE PASAJE Y/O ENCOMIENDA')                 
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnConsultarMillas','CONSULTA DE MILLAS DE PASAJERO FRECUENTE')  
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnCanjeMillas','CANJE DE MILLAS')    
   insert into mondongo.funcionalidades (funcionalidad_nombre, funcionalidad_descripcion) values ('btnListado','LISTADO ESTADISTICO')
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
        insert into MONDONGO.USUARIOS(usuario_nombre,usuario_contraseña) values ('ADMINUNO','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
        insert into MONDONGO.USUARIOS(usuario_nombre,usuario_contraseña)    values ('ADMINDOS','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')    
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
            MONDONGO.fx_cantidad_butacas(Aeronave_Matricula, 'PASILLO'),
            MONDONGO.fx_cantidad_butacas(Aeronave_Matricula, 'VENTANILLA')
    from gd_esquema.Maestra
    group by Aeronave_Matricula, Aeronave_Modelo, aeronave_fabricante, Tipo_Servicio
END
GO
CREATE PROCEDURE [MONDONGO].[pr_cargar_rutas]
AS
BEGIN
    insert into MONDONGO.rutas(codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, precio_base_pasaje, precio_base_kg, horas_vuelo)
    select ruta_codigo,
        mondongo.fx_busca_id_ciudad(RIGHT(UPPER(Ruta_Ciudad_Origen), LEN(Ruta_Ciudad_Origen) - 1)),
        mondongo.fx_busca_id_ciudad(RIGHT(UPPER(Ruta_Ciudad_Destino), LEN(Ruta_Ciudad_Destino) - 1)),
        --mondongo.fx_busca_id_tipo_servicio(Tipo_Servicio),
        max(Ruta_Precio_BasePasaje),
        max(Ruta_Precio_BaseKG),
        datediff(hh, FechaSalida,FechaLLegada)
    from gd_esquema.Maestra
    group by ruta_codigo, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, tipo_servicio, datediff(hh, FechaSalida,FechaLLegada)
    order by Ruta_Ciudad_Origen
END
GO

create procedure mondongo.pr_cargar_ruta_tipo_servicio
AS
BEGIN
	insert into MONDONGO.ruta_tipo_servicio
	select a.idr, a.idts
	from (
		select r.id_ruta as idr, mondongo.fx_busca_id_tipo_servicio(m.Tipo_Servicio) as idts 
		from gd_esquema.Maestra m, MONDONGO.rutas r
		where mondongo.fx_busca_id_ciudad(RIGHT(UPPER(m.Ruta_Ciudad_Origen), LEN(m.Ruta_Ciudad_Origen) - 1)) = r.id_ciudad_origen
			 and mondongo.fx_busca_id_ciudad(RIGHT(UPPER(m.Ruta_Ciudad_Destino), LEN(m.Ruta_Ciudad_Destino) - 1)) = r.id_ciudad_destino
	) a
	group by a.idr, a.idts
END
GO

create PROCEDURE [MONDONGO].[pr_cargar_pasajes]
AS
BEGIN
    insert into mondongo.pasajes(pasaje_venta_pnr,pasaje_viaje_id, pasaje_pasajero_id,pasaje_monto,butaca_id,estado)
	select	m.pasaje_codigo,
			(select v.viaje_id
			from mondongo.viajes v
			inner join mondongo.rutas r on v.viaje_ruta_id = r.id_ruta
			inner join mondongo.ciudades c1 on c1.id_ciudad = r.id_ciudad_origen
			inner join mondongo.ciudades c2 on c2.id_ciudad = r.id_ciudad_destino
			inner join mondongo.tipos_servicio ts on ts.id_tipo_servicio = r.id_tipo_servicio
			where c1.nombre = RIGHT(upper(Ruta_Ciudad_Origen), LEN(Ruta_Ciudad_Origen) - 1)
			and c2.nombre = RIGHT(upper(Ruta_Ciudad_Destino), LEN(Ruta_Ciudad_Destino) - 1)
			and v.fecha_salida = m.FechaSalida
			and v.aeronave_matricula = m.aeronave_matricula
			and ts.tipo_servicio = m.Tipo_Servicio) as pasaje_viaje_id,
			c.cliente_id,
			m.pasaje_precio,
			(select butaca_id from mondongo.butacas b where b.butaca_tipo=m.Butaca_Tipo and	b.butaca_nro = m.Butaca_Nro and b.butaca_piso=1 and b.aeronave_matricula=m.Aeronave_Matricula),
			0
	from	gd_esquema.Maestra m inner join	mondongo.clientes c on (m.Cli_dni = c.cliente_dni and UPPER(m.cli_apellido) = UPPER(c.cliente_apellido))
	where	m.pasaje_codigo <> 0
END
GO
CREATE PROCEDURE [MONDONGO].[pr_cargar_paquetes]
AS
BEGIN
    insert into mondongo.paquetes(paquete_venta_pnr,paquete_viaje_id, paquete_kg,paquete_monto,paquete_piso,estado)
	select	m.paquete_codigo,
			(select v.viaje_id
			from mondongo.viajes v
			inner join mondongo.rutas r on v.viaje_ruta_id = r.id_ruta
			inner join mondongo.ciudades c1 on c1.id_ciudad = r.id_ciudad_origen
			inner join mondongo.ciudades c2 on c2.id_ciudad = r.id_ciudad_destino
			inner join mondongo.tipos_servicio ts on ts.id_tipo_servicio = r.id_tipo_servicio
			where c1.nombre = RIGHT(upper(Ruta_Ciudad_Origen), LEN(Ruta_Ciudad_Origen) - 1)
			and c2.nombre = RIGHT(upper(Ruta_Ciudad_Destino), LEN(Ruta_Ciudad_Destino) - 1)
			and v.fecha_salida = m.FechaSalida
			and v.aeronave_matricula = m.aeronave_matricula
			and ts.tipo_servicio = m.Tipo_Servicio) as paquete_viaje_id,
			m.paquete_kg,
			m.paquete_precio,
			0,
			0
	from	gd_esquema.Maestra m
	where	m.paquete_codigo <> 0
END
go
CREATE PROCEDURE mondongo.pr_cargar_ventas
as
begin
	insert into mondongo.ventas (venta_fecha_compra, venta_id_pagador, venta_tipo_pago_id, venta_estado, venta_pnr)
	(select		(case when m.pasaje_codigo>0 
					then m.pasaje_fechaCompra 
					else m.paquete_fechaCompra 
				end) as fechaCompra,				
				c.cliente_id,
				1,
				0,
				(case when m.pasaje_codigo>0 
					then m.pasaje_codigo 
					else m.paquete_codigo 
				end) as venta_pnr		
	from		gd_esquema.Maestra m	
	inner join	mondongo.clientes c on (m.Cli_dni = c.cliente_dni and m.cli_apellido = c.cliente_apellido)
	group by	(case when pasaje_codigo>0 
					then m.pasaje_fechaCompra 
					else m.paquete_fechaCompra 
				end), 
				m.fechaSalida,				
				c.cliente_id,
				(case when m.pasaje_codigo>0 
					then m.pasaje_codigo 
					else m.paquete_codigo 
				end))
end
go
CREATE PROCEDURE mondongo.pr_cargar_viajes
as
begin
    insert into mondongo.viajes(aeronave_matricula,viaje_ruta_id, fecha_salida, fecha_llegada, fecha_llegada_estimada, cantidad_kg_disponibles,estado)
    select  m.Aeronave_Matricula,
            mondongo.fx_busca_id_ruta(RIGHT(UPPER(m.Ruta_Ciudad_Origen), LEN(m.Ruta_Ciudad_Origen) - 1), RIGHT(UPPER(m.Ruta_Ciudad_Destino), LEN(m.Ruta_Ciudad_Destino) - 1), m.Tipo_Servicio) as viaje_ruta_id,
            m.FechaSalida,
            m.FechaLLegada,
            m.Fecha_LLegada_Estimada,
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
create procedure mondongo.pr_cargar_butacas
AS
BEGIN
	insert into MONDONGO.butacas(aeronave_matricula, butaca_nro, butaca_tipo, butaca_piso)
	select distinct Aeronave_Matricula, Butaca_Nro, Butaca_Tipo, butaca_piso
	from gd_esquema.Maestra
	where Pasaje_Codigo<>0
	order by Aeronave_Matricula, Butaca_Nro
END
GO
create procedure mondongo.pr_actualizar_viajes
as
begin	
	update mondongo.viajes
	set cantidad_kg_disponibles = cantidad_kg_disponibles - q.cantidad
	from mondongo.viajes v
	inner join (select pq.paquete_viaje_id, sum(pq.paquete_kg) as cantidad
				from mondongo.paquetes pq
				group by pq.paquete_viaje_id) q
	on q.paquete_viaje_id = v.viaje_id
end
go
create procedure mondongo.pr_cargar_butacas_viaje
AS
BEGIN
	insert into MONDONGO.butacas_viaje(viaje_id, butaca_id)
	select v.viaje_id, b.butaca_id
	from MONDONGO.viajes v, MONDONGO.aeronaves a, MONDONGO.butacas b
	where a.matricula=v.aeronave_matricula
		and a.matricula=b.aeronave_matricula
	order by 1,2
	
	update bv
	set estado = 'V'
	from MONDONGO.butacas_viaje bv, mondongo.pasajes p,  mondongo.viajes v
	where p.pasaje_viaje_id= v.viaje_id
		and bv.butaca_id = p.butaca_id
		and bv.viaje_id = v.viaje_id
END
GO

/*TABLAS*/
create table mondongo.roles
(rol_id numeric(18,0) identity primary key,
rol_nombre nvarchar(20) not null,
rol_habilitado int not null default 1 check(rol_habilitado in (0,1,2))
)
GO
create table mondongo.usuarios
(usuario_id numeric(18,0) primary key identity,
usuario_nombre nvarchar(20) not null unique,
usuario_contraseña nvarchar(255) not null,
usuario_intentos_fallidos int default 0 check(usuario_intentos_fallidos >= 0),
usuario_bloqueado int default 0 check(usuario_bloqueado in (0,1))
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
beneficio_cantidad_cuotas numeric(2) check(beneficio_cantidad_cuotas > 0),
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
    tipo_servicio nvarchar(255),
	costo_adicional numeric(18,0) check(costo_adicional >= 0)
)
GO
create table MONDONGO.rutas(
    id_ruta numeric(18) primary key identity,
    codigo_ruta numeric(18) not null,
    id_ciudad_origen numeric(18,0) not null REFERENCES mondongo.ciudades(id_ciudad),
    id_ciudad_destino numeric(18,0) not null REFERENCES mondongo.ciudades(id_ciudad),
    id_tipo_servicio numeric(8) REFERENCES mondongo.tipos_servicio(id_tipo_servicio),
    precio_base_kg numeric(18,2) check(precio_base_kg >= 0),
    precio_base_pasaje numeric(18,2) check(precio_base_pasaje >= 0),
	horas_vuelo numeric(18, 0) NULL,
	estado numeric(1,0) default 0 check(estado in (0,1))
)
GO
create table mondongo.ruta_tipo_servicio(
	id_ruta numeric(18,0) references mondongo.rutas(id_ruta),
	id_tipo_servicio numeric(8,0) references mondongo.tipos_servicio(id_tipo_servicio)
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
    [cantidad_butacas_ven] [numeric](18, 0) NULL,
    [cantidad_butacas_pas] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
create table MONDONGO.aeronaves_bajas(
	id_aeronave_baja numeric(18,0) primary key identity,
	aeronave_matricula nvarchar(255) not null REFERENCES mondongo.aeronaves(matricula),
	fecha_proceso date not null DEFAULT (getdate()),
	fecha_fuera_servicio date,
	fecha_reinicio_servicio date,
	fecha_baja_definitiva date,
	tipo_baja nvarchar(255)
)
GO
create table mondongo.viajes(
    viaje_id numeric(18,0) identity primary key,
    viaje_ruta_id numeric(18) references mondongo.rutas(id_ruta),
    aeronave_matricula nvarchar(255) references mondongo.aeronaves(matricula),
    fecha_salida datetime not null,
    fecha_llegada datetime,
    fecha_llegada_estimada datetime not null,    
	cantidad_kg_disponibles numeric(18,0) not null check(cantidad_kg_disponibles>=0),
	estado numeric(1,0) default 0 check(estado in (0,1,2))
)
GO

create table mondongo.ventas(
	venta_pnr numeric(18,0) primary key,
	venta_fecha_compra datetime not null default getdate(),	
	venta_id_pagador numeric(18,0) not null references mondongo.clientes(cliente_id),
	venta_tipo_pago_id numeric(18,0) references mondongo.tipos_pago(tipo_pago_id),
	venta_estado numeric(1,0) check(venta_estado in (0,1,2))
)
GO
create table mondongo.butacas(
	butaca_id numeric(18,0) primary key identity,
	aeronave_matricula nvarchar(255) references mondongo.aeronaves(matricula),
	butaca_nro numeric(18,0),
	butaca_tipo nvarchar(255),
	butaca_piso numeric(18,0) default 1
)
GO
create table mondongo.pasajes(
	pasaje_id numeric(18,0) primary key identity,
	pasaje_venta_pnr numeric(18,0) not null references mondongo.ventas(venta_pnr),
	pasaje_viaje_id numeric(18,0) not null references mondongo.viajes(viaje_id),
	pasaje_pasajero_id numeric(18,0) references mondongo.clientes(cliente_id),
	pasaje_monto numeric(18,2) default 0 check(pasaje_monto >= 0),
	butaca_id numeric(18,0) references mondongo.butacas(butaca_id),
	estado numeric(1,0) check(estado in (0,1,2))
)
GO
create table mondongo.paquetes(
	paquete_id numeric(18,0) primary key identity,
	paquete_venta_pnr numeric(18,0) not null references mondongo.ventas(venta_pnr),
	paquete_viaje_id numeric(18,0) not null references mondongo.viajes(viaje_id),
	paquete_kg numeric(18,0) default 0 check(paquete_kg >= 0),
	paquete_monto numeric(18,2) default 0 check(paquete_monto >= 0),
	paquete_piso numeric(18,0) not null default 0 check(paquete_piso = 0),
	estado numeric(1,0) check(estado in (0,1,2))
)
GO

create table mondongo.productos(
	id_producto numeric(18,0) primary key identity,
	stock numeric(3,0) not null,
	descripcion nvarchar(255) not null,
	costo_millas numeric(7,0) not null check(costo_millas >= 0)
)
GO

create table mondongo.historial_millas(
	id_historial numeric(18,0) primary key identity,
	id_cliente numeric(18,0) not null references mondongo.clientes(cliente_id),			
	millas numeric(7,2) not null check (millas >= 0),
	fecha_operacion datetime default getdate(),
	tipo_operacion int not null check (tipo_operacion in (1,2)),
	descripcion varchar(255) null
)
go
create table mondongo.canje_millas(
	id_canje numeric(18,0) primary key identity,
	id_producto numeric(18,0) not null references mondongo.productos(id_producto),
	id_cliente numeric(18,0) not null references mondongo.clientes(cliente_id),
	cantidad numeric(2) not null check(cantidad >= 0),
	fecha_canje datetime default getdate()
)
create table mondongo.butacas_viaje(
	viaje_id numeric(18,0) not null references mondongo.viajes(viaje_id) ,
	butaca_id numeric(18,0) not null references mondongo.butacas(butaca_id),
	estado nchar(1) check (estado in ('L','V')) default 'L'
	CONSTRAINT [PK_butacas_viaje] PRIMARY KEY CLUSTERED 
	(
		[viaje_id] ASC,
		[butaca_id] ASC
	)
)
GO

CREATE TABLE [MONDONGO].[devoluciones_pasajes](
	[cod_devolucion] [numeric](18, 0) NOT NULL identity,
	[venta_pnr] [numeric](18, 0) NULL,
	[fecha_devolucion] [datetime] NULL,
	[id_pasaje] [numeric](18, 0) NULL,
	[motivo] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [MONDONGO].[devoluciones_pasajes]  WITH CHECK ADD FOREIGN KEY([id_pasaje])
REFERENCES [MONDONGO].[pasajes] ([pasaje_id])
GO



CREATE TABLE [MONDONGO].[devoluciones_paquetes](
	[cod_devolucion] [numeric](18, 0) NOT NULL identity,
	[venta_pnr] [numeric](18, 0) NULL,
	[fecha_devolucion] [datetime] NULL,
	[id_paquete] [numeric](18, 0) NULL,
	[motivo] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [MONDONGO].[devoluciones_paquetes]  WITH CHECK ADD FOREIGN KEY([id_paquete])
REFERENCES [MONDONGO].[paquetes] ([paquete_id])
GO

/* INDICES */

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

CREATE INDEX index_cliente
ON mondongo.clientes (cliente_id)
GO


create trigger mondongo.tr_cancelar_ruta
on mondongo.rutas
after update
as
begin
	DECLARE @tempRuta TABLE
	(
		ruta_id numeric(18,0)
	);

	insert into @tempRuta
	select r.id_ruta
	from inserted i, MONDONGO.rutas r, deleted d
	where i.id_ruta=r.id_ruta
		and i.estado<>d.estado;	
	
	update MONDONGO.viajes
	set estado = (select top 1 estado from inserted)
	where viaje_ruta_id in (select ruta_id from @tempRuta)
end
go
/* TRIGGERS */
create TRIGGER [MONDONGO].[tr_cancelar_viajes] 
   ON  [MONDONGO].[viajes] 
   AFTER UPDATE
AS 
BEGIN
	DECLARE @tempTable TABLE
	(
		viaje_id numeric(18,0)
	);
	
	insert into @tempTable
	select i.viaje_id
	from inserted i, deleted d
	where i.estado<>d.estado
		and i.viaje_id=d.viaje_id;
	
	update MONDONGO.paquetes
	set estado = (select top 1 estado from inserted)
	where paquete_viaje_id in (select viaje_id from @tempTable)

	update MONDONGO.pasajes
	set estado = (select top 1 estado from inserted)
	where pasaje_viaje_id in (select viaje_id from @tempTable)
	
END
GO

CREATE TRIGGER [MONDONGO].[tr_cancelar_ventas] 
   ON  [MONDONGO].[ventas] 
   AFTER UPDATE
AS 
BEGIN
	DECLARE @tempPNR TABLE
	(
		venta_pnr numeric(18,0)
	);
	
	insert into @tempPNR
	select i.venta_pnr
	from inserted i, deleted d
	where i.venta_estado<>d.venta_estado
		and i.venta_pnr=d.venta_pnr;

	update MONDONGO.paquetes
	set estado = (select top 1 venta_estado from inserted)
	where paquete_venta_pnr in (select venta_pnr from @tempPNR)

	update MONDONGO.pasajes
	set estado = (select top 1 venta_estado from inserted)
	where pasaje_venta_pnr in (select venta_pnr from @tempPNR)
	
END
GO

/* MIGRACION */

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
exec mondongo.pr_cargar_butacas
go
exec mondongo.pr_cargar_ciudades
go
exec mondongo.pr_cargar_rutas
go
exec mondongo.pr_cargar_viajes
go
exec mondongo.pr_cargar_ventas
go
exec mondongo.pr_cargar_pasajes
go
exec mondongo.pr_cargar_paquetes
go
exec mondongo.pr_cargar_butacas_viaje
go
exec mondongo.pr_actualizar_viajes
go

create trigger mondongo.tr_generar_butacas
   ON  [MONDONGO].[aeronaves] 
   AFTER INSERT
AS 
BEGIN
	DECLARE @I INT, @CANT_PAS INT, @CANT_VEN INT, @MATRICULA nvarchar(255)
	/*SET @I = 1
	SET @CANT_PAS = (select i.cantidad_butacas_pas from inserted i)
	SET @CANT_VEN = (select i.cantidad_butacas_ven from inserted i)
	SET @MATRICULA = (select i.matricula from inserted i)

    WHILE @I <= @CANT_PAS
    BEGIN
        INSERT INTO mondongo.butacas(aeronave_matricula, butaca_nro, butaca_piso, butaca_tipo)
        VALUES(@MATRICULA, @I, 1, 'PASILLO')

        SET @I = @I + 1
    END

	WHILE @I <= (@CANT_PAS + @CANT_VEN)
    BEGIN
        INSERT INTO mondongo.butacas(aeronave_matricula, butaca_nro, butaca_piso, butaca_tipo)
        VALUES(@MATRICULA, @I, 1, 'VENTANILLA')

        SET @I = @I + 1
    END
	*/
END
GO
CREATE TRIGGER [MONDONGO].[tr_ocupar_butaca] 
   ON  [MONDONGO].[pasajes] 
   AFTER INSERT
AS 
BEGIN
	
	DECLARE @tempButacaViaje TABLE
	(
		viaje_id numeric(18,0),
		butaca_id numeric(18,0),
		estado numeric(18,0)
	);
	
	insert into @tempButacaViaje
	select
	i.pasaje_viaje_id,
	i.butaca_id,
	i.estado
	from inserted i

	update bv
	set estado = 
		( CASE
			WHEN (tbv.estado = 0) THEN 'V'
			WHEN (tbv.estado = 1) THEN 'L'
			END)
	from mondongo.butacas_viaje bv
	inner join @tempButacaViaje tbv on tbv.butaca_id = bv.butaca_id and tbv.viaje_id = bv.viaje_id
END
GO
CREATE TRIGGER [MONDONGO].[tr_desocupar_butaca] 
   ON  [MONDONGO].[pasajes] 
   AFTER UPDATE
AS 
BEGIN
	
	DECLARE @tempButacaViaje TABLE
	(
		viaje_id numeric(18,0),
		butaca_id numeric(18,0),
		estado numeric(18,0)
	);		
		
	insert into @tempButacaViaje
	select i.pasaje_viaje_id,
	i.butaca_id,
	i.estado
	from inserted i, deleted d
	where i.estado <> d.estado
	and i.pasaje_id = d.pasaje_id;
	
	update bv
	set estado = 
		( CASE
			WHEN (tbv.estado = 0) THEN 'V'
			WHEN (tbv.estado = 1) THEN 'L'
			END)
	from mondongo.butacas_viaje bv
	inner join @tempButacaViaje tbv on tbv.butaca_id = bv.butaca_id and tbv.viaje_id = bv.viaje_id
END
GO

create procedure [MONDONGO].[pr_generar_butacas](@MATRICULA nvarchar(255), @CANT_PAS INT, @CANT_VEN INT)
AS 
BEGIN
	
	delete from MONDONGO.butacas
	where aeronave_matricula=@MATRICULA

	DECLARE @I INT
	SET @I = 1

    WHILE @I <= @CANT_PAS
    BEGIN
        INSERT INTO mondongo.butacas(aeronave_matricula, butaca_nro, butaca_piso, butaca_tipo)
        VALUES(@MATRICULA, @I, 1, 'PASILLO')

        SET @I = @I + 1
    END

	WHILE @I <= (@CANT_PAS + @CANT_VEN)
    BEGIN
        INSERT INTO mondongo.butacas(aeronave_matricula, butaca_nro, butaca_piso, butaca_tipo)
        VALUES(@MATRICULA, @I, 1, 'VENTANILLA')

        SET @I = @I + 1
    END

END
