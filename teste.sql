create database teste;
go

use teste;
go

create table TB_funcionario
( i_fun_id int identity (1,1) Primary key,
vc_func_nome varchar(200), 
vc_func_funcional varchar(50), 
vc_func_filial varchar (50)
);

insert into TB_funcionario( vc_func_nome, vc_func_funcional, vc_func_filial)
	values				  ('Paulo da silva','00015','RJ')

insert into TB_funcionario( vc_func_nome, vc_func_funcional, vc_func_filial)
	values				  ('Alexandre Gomes','00017','RJ')

insert into TB_funcionario( vc_func_nome, vc_func_funcional, vc_func_filial)
	values				  ('Joel Ortega','00033','SP')

insert into TB_funcionario( vc_func_nome, vc_func_funcional, vc_func_filial)
	values				  ('Bruno Cardoso','00035','SP')
	
	select * from TB_funcionario
	

	truncate table tb_funcionario
