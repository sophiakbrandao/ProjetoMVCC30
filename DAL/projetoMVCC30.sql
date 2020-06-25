create database ProjetoMVCC30;
use ProjetoMVCC30;

create table tbl_clienteC30(
id_cliente int(11) not null primary key,
nome_cliente varchar(45) not null,
sobrenome_cliente varchar(45) not null,
email_cliente varchar(50) not null,
senha_cliente varchar(45) not null,
cpf_cliente varchar(11) not null,
nome_mae varchar(50) not null,
tp_usuario int(1) default null 
);

select * from tbl_clienteC30;