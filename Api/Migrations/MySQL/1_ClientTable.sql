CREATE TABLE cliente (
  cliente_id BIGINT NOT NULL,
  nombre VARCHAR(200) DEFAULT NULL,
  apellido VARCHAR(200) DEFAULT NULL,
  rol int(11) DEFAULT NULL,
  PRIMARY KEY (cliente_id)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into cliente (cliente_id, nombre, apellido,  rol ) values(1, 'cli1', 'ape1', 1);
insert into cliente (cliente_id, nombre, apellido,  rol )values(2, 'cli2', 'ape2', 2);
insert into cliente (cliente_id, nombre, apellido,  rol ) values(3, 'cli3', 'ape3', 3);