CREATE TABLE customer(
  customer_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  identity_document VARCHAR(20) NOT NULL,
  active BIT NOT NULL,
  PRIMARY KEY(customer_id),
  INDEX IX_customer_last_first_name(last_name, first_name),
  UNIQUE INDEX UQ_customer_identity_document(identity_document)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

insert into practiceclass.cliente values(1, 'cli1', 'ape1', 1);
insert into practiceclass.cliente values(2, 'cli2', 'ape2', 2);
insert into practiceclass.cliente values(3, 'cli3', 'ape3', 3);