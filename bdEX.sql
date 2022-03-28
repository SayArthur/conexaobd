create database dbExemplo;
use dbExemplo;

create table tbUsuario(
IDusu int primary key auto_increment,
NomeUsu varchar(50) not null,
Cargo varchar(50) not null,
DataNasc date
);

insert into tbUsuario (NomeUsu, cargo, DataNasc)
	values('Bob', 'Monstrorista','2019/04/06'),
    ('Maria','171','2019/12/04');
    
    select * from tbUsuario;
     
     delimiter $$
     create procedure InsereUsu (pNomeUsu varchar(50),
								pCargo varchar(50),
								pDataNasc date)
	begin
    insert into tbUsuario (NomeUsu, cargo, DataNasc)
          values (pNomeUsu, pCargo, pDataNasc);
	END
    $$

    call InsereUsu ('DST', 'Aluno', '2020/02/07');
    
    