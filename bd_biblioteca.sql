-- Script para la BD

-- Crear la BD
create database bd_biblioteca
go

-- Poner en uso la BD
use bd_biblioteca
go


-- Crear las tablas
create table tb_pais (
	codigo_pais char(5) not null primary key,
	pais varchar(40) not null)
go

create table tb_autor (
	codigo_autor char(5) not null primary key,
	nombre varchar(15),
	ap_paterno varchar(15),
	ap_materno varchar(15),
	fecha_nacimiento date,
	numero_premios int,
	autor_codigo_pais char(5) not null foreign key references tb_pais (codigo_pais))
go

-- Agregar registros
insert into tb_pais values
('P0001', 'Perú'),
('P0002', 'Colombia'),
('P0003', 'España'),
('P0004', 'México')
go

-- select * from tb_pais
-- go

set dateformat dmy
go

insert into tb_autor values
('A0001', 'Mario', 'Vargas', 'Llosa', '28/03/1936', 4, 'P0001'),
('A0002', 'Gabriel', 'García', 'Marquez', '06/03/1927', 2, 'P0002')
go

-- select * from tb_autor
-- go

-- update tb_autor set nombre = 'Javier', ap_paterno = 'Rojas'
-- where codigo_autor = 'A0001'
-- go

select tba.codigo_autor,
       concat(tba.nombre, ' ', tba.ap_paterno, ' ', tba.ap_materno) as 'autor',
	   tba.fecha_nacimiento, tba.numero_premios,
	   tbp.pais
from tb_autor tba inner join tb_pais tbp
on (tba.autor_codigo_pais = tbp.codigo_pais)
go


-- PAIS
-- -------------------------------
--sp_listar pais
create procedure  sp_listar_pais
as
begin 
	select * from tb_pais
	order by pais asc
end
go

execute sp_listar_pais
go



-- dop procedure sp_listar_pais
-- go



-- -------------------------------
-- Registrar: sp_registrar_pais
create procedure sp_registrar_pais
	@cod char(5), @nom varchar(40)
as
begin
	insert into tb_pais values
	(@cod, @nom)
end
go

execute sp_registrar_pais 'P0005', 'Argentina'
go



-- -------------------------------
-- Editar: sp_editar_pais
create procedure sp_editar_pais
	@cod char(5), @nom varchar(40)
as
begin
	update tb_pais set pais= @nom
	where codigo_pais = @cod	
end
go

execute sp_editar_pais 'P0005', 'Argentinasss'
go


-- -------------------------------
-- Borrar: sp_borrar_pais
create procedure sp_borrar_pais
	@cod char(5)
as
begin
	delete from tb_pais
	where codigo_pais = @cod
end
go

execute sp_borrar_pais 'P0005'
go







-- AUTOR 

-- -------------------------------
--sp_listar autor
create procedure  sp_listar_autor
as
begin 
	select * from tb_autor
	order by nombre asc
end
go

execute sp_listar_autor
go



-- dop procedure sp_listar_autor
-- go



-- -------------------------------
-- Registrar: sp_registrar_pais
create procedure sp_registrar_autor
	@cod_autor char(5), @nom varchar(15), @ap_paterno varchar(15), @ap_materno varchar(15), @fecha_nacimiento date, @premios int, @autor_codigo char(5)
as
begin
	insert into tb_autor values
	(@cod_autor , @nom , @ap_paterno , @ap_materno , @fecha_nacimiento, @premios, @autor_codigo)
end
go

execute sp_registrar_autor 'A0003', 'ap_Paterno', 'ap_Materno', 'Nombres', '2004-04-12', 100, 'P0001'
go



-- -------------------------------
-- Editar: sp_editar_autor



create procedure sp_editar_autor
	@cod_autor char(5), @nom varchar(15), @ap_paterno varchar(15), @ap_materno varchar(15), @fecha_nacimiento date, @premios int, @autor_codigo char(5)
as
begin

	UPDATE tb_autor
	SET nombre = @nom,
		ap_paterno = @ap_paterno,
		ap_materno = @ap_materno,
		fecha_nacimiento = @fecha_nacimiento,
		numero_premios = @premios
	WHERE codigo_autor = @cod_autor;

end
go

execute sp_editar_autor 'A0003', 'ap_Paterno', 'ap_Materno', 'Nombres', '2004-04-10', 200, 'P0003'
go


-- -------------------------------
-- Borrar: sp_borrar_autor
create procedure sp_borrar_autor
	@cod_autor char(5)
as
begin
	delete from tb_autor
	where codigo_autor = @cod_autor
end
go

execute sp_borrar_autor 'A0003'
go