CREATE TABLE proyecto (
  proyecto_id int(11) NOT NULL,
  balance decimal(10,2) NOT NULL,
  currency varchar(3) NOT NULL,
  pais_id int(11) DEFAULT NULL,
  cliente_id int(11) DEFAULT NULL,
  PRIMARY KEY (proyecto_id)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into proyecto (proyecto_id, balance, currency,  pais_id,  cliente_id) values(1, 100, 'USD', 5, 1);
insert into proyecto (proyecto_id, balance, currency,  pais_id,  cliente_id) values(2, 200, 'PEN', 1, 1)