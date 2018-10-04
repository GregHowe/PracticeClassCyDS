CREATE TABLE usuario (
  usuario_id BIGINT NOT NULL,
  nombre varchar(200) DEFAULT NULL,
  apellido varchar(200) DEFAULT NULL,
  cliente_id int(11) DEFAULT NULL,
  PRIMARY KEY (usuario_id)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into usuario (usuario_id, nombre, apellido,  cliente_id) values(1, 'user1', 'ape1', 1);
insert into usuario (usuario_id, nombre, apellido,  cliente_id) values(2, 'user2', 'ape2', 1);
insert into usuario (usuario_id, nombre, apellido,  cliente_id) values(3, 'user3', 'ape3', 1);