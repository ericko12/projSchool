-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.6.19


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema universal
--

CREATE DATABASE IF NOT EXISTS universal;
USE universal;

--
-- Temporary table structure for view `general`
--
DROP TABLE IF EXISTS `general`;
DROP VIEW IF EXISTS `general`;
CREATE TABLE `general` (
  `idVenta` int(10) unsigned,
  `NomCte` varchar(45),
  `fecVta` datetime,
  `totalVta` decimal(10,2),
  `Tipopago` varchar(30)
);

--
-- Temporary table structure for view `vistaabono`
--
DROP TABLE IF EXISTS `vistaabono`;
DROP VIEW IF EXISTS `vistaabono`;
CREATE TABLE `vistaabono` (
  `NomCte` varchar(45),
  `FecAbono` datetime,
  `Abono` decimal(10,0),
  `Saldo` decimal(10,0)
);

--
-- Temporary table structure for view `vistaagotados`
--
DROP TABLE IF EXISTS `vistaagotados`;
DROP VIEW IF EXISTS `vistaagotados`;
CREATE TABLE `vistaagotados` (
  `NomProd` varchar(45),
  `Marca` varchar(45),
  `descrip` varchar(100),
  `existencia` decimal(10,0)
);

--
-- Temporary table structure for view `vistaclasificacion`
--
DROP TABLE IF EXISTS `vistaclasificacion`;
DROP VIEW IF EXISTS `vistaclasificacion`;
CREATE TABLE `vistaclasificacion` (
  `idClasif` int(10) unsigned,
  `nomClasif` varchar(45)
);

--
-- Temporary table structure for view `vistaclientes`
--
DROP TABLE IF EXISTS `vistaclientes`;
DROP VIEW IF EXISTS `vistaclientes`;
CREATE TABLE `vistaclientes` (
  `idCte` int(10) unsigned,
  `RFCCte` varchar(15),
  `NomCte` varchar(45),
  `DirCte` varchar(65),
  `ColCte` varchar(45),
  `CPCte` varchar(45),
  `Poblacion` varchar(45),
  `TelCte` varchar(20),
  `Afiliacion` datetime,
  `email` varchar(45)
);

--
-- Temporary table structure for view `vistadetvta`
--
DROP TABLE IF EXISTS `vistadetvta`;
DROP VIEW IF EXISTS `vistadetvta`;
CREATE TABLE `vistadetvta` (
  `idVenta` int(10) unsigned,
  `NomProd` varchar(45),
  `cantVta` decimal(10,0),
  `PrecioUnit` decimal(10,0),
  `totalVta` decimal(10,2)
);

--
-- Temporary table structure for view `vistaempleado`
--
DROP TABLE IF EXISTS `vistaempleado`;
DROP VIEW IF EXISTS `vistaempleado`;
CREATE TABLE `vistaempleado` (
  `nomEmp` varchar(45),
  `fecIngreso` date,
  `domEmpl` varchar(45),
  `telEmpe` varchar(15)
);

--
-- Temporary table structure for view `vistagerente`
--
DROP TABLE IF EXISTS `vistagerente`;
DROP VIEW IF EXISTS `vistagerente`;
CREATE TABLE `vistagerente` (
  `NomGer` varchar(45),
  `FecIngreso` date,
  `domGer` varchar(45),
  `telGer` varchar(15),
  `RFCGer` varchar(15)
);

--
-- Temporary table structure for view `vistainventario`
--
DROP TABLE IF EXISTS `vistainventario`;
DROP VIEW IF EXISTS `vistainventario`;
CREATE TABLE `vistainventario` (
  `Barcode` varchar(45),
  `NomProd` varchar(45),
  `Marca` varchar(45),
  `descrip` varchar(100),
  `Ubicacion` varchar(15),
  `Existencia` decimal(10,0),
  `costo` decimal(12,2),
  `Descuent` int(10) unsigned
);

--
-- Temporary table structure for view `vistaproducto`
--
DROP TABLE IF EXISTS `vistaproducto`;
DROP VIEW IF EXISTS `vistaproducto`;
CREATE TABLE `vistaproducto` (
  `Barcode` varchar(45),
  `NomProd` varchar(45),
  `descrip` varchar(100),
  `Marca` varchar(45),
  `Precio` decimal(12,2),
  `Existencia` decimal(10,0),
  `Unidad` varchar(15),
  `Ubicacion` varchar(15)
);

--
-- Temporary table structure for view `vistaproveedor`
--
DROP TABLE IF EXISTS `vistaproveedor`;
DROP VIEW IF EXISTS `vistaproveedor`;
CREATE TABLE `vistaproveedor` (
  `NomProv` varchar(45),
  `dirProv` varchar(45),
  `TelProv` varchar(15),
  `RFCProv` varchar(20),
  `emailProve` varchar(25)
);

--
-- Temporary table structure for view `vistareportecaja`
--
DROP TABLE IF EXISTS `vistareportecaja`;
DROP VIEW IF EXISTS `vistareportecaja`;
CREATE TABLE `vistareportecaja` (
  `idVenta` int(10) unsigned,
  `NomCte` varchar(45),
  `fecVta` datetime,
  `totalVta` decimal(10,2),
  `Tipopago` varchar(30)
);

--
-- Temporary table structure for view `vistareportecredito`
--
DROP TABLE IF EXISTS `vistareportecredito`;
DROP VIEW IF EXISTS `vistareportecredito`;
CREATE TABLE `vistareportecredito` (
  `idVenta` int(10) unsigned,
  `NomCte` varchar(45),
  `fecVta` datetime,
  `totalVta` decimal(10,2),
  `Tipopago` varchar(30)
);

--
-- Temporary table structure for view `vistareportetarjeta`
--
DROP TABLE IF EXISTS `vistareportetarjeta`;
DROP VIEW IF EXISTS `vistareportetarjeta`;
CREATE TABLE `vistareportetarjeta` (
  `idVenta` int(10) unsigned,
  `NomCte` varchar(45),
  `fecVta` datetime,
  `totalVta` decimal(10,2),
  `Tipopago` varchar(30)
);

--
-- Definition of table `abono`
--

DROP TABLE IF EXISTS `abono`;
CREATE TABLE `abono` (
  `idAbono` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idCte` int(10) unsigned NOT NULL,
  `FecAbono` datetime DEFAULT NULL,
  `Saldo` decimal(10,0) NOT NULL,
  `Abono` decimal(10,0) NOT NULL,
  `credMax` decimal(10,0) NOT NULL,
  `idVenta` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idAbono`,`idCte`),
  KEY `FKPago` (`idCte`),
  KEY `FKPago1` (`idVenta`),
  CONSTRAINT `FKPago` FOREIGN KEY (`idCte`) REFERENCES `clientes` (`idCte`),
  CONSTRAINT `FKPago1` FOREIGN KEY (`idVenta`) REFERENCES `ventas` (`idVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `abono`
--

/*!40000 ALTER TABLE `abono` DISABLE KEYS */;
INSERT INTO `abono` (`idAbono`,`idCte`,`FecAbono`,`Saldo`,`Abono`,`credMax`,`idVenta`) VALUES 
 (1,2,'2014-08-26 18:23:11','17','1','0',13);
/*!40000 ALTER TABLE `abono` ENABLE KEYS */;


--
-- Definition of table `caja`
--

DROP TABLE IF EXISTS `caja`;
CREATE TABLE `caja` (
  `idcorte` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fechcorte` datetime NOT NULL,
  `cantidad` decimal(10,0) NOT NULL,
  `estado` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`idcorte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `caja`
--

/*!40000 ALTER TABLE `caja` DISABLE KEYS */;
/*!40000 ALTER TABLE `caja` ENABLE KEYS */;


--
-- Definition of table `cfgrcn`
--

DROP TABLE IF EXISTS `cfgrcn`;
CREATE TABLE `cfgrcn` (
  `idCF` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TCK_VT` varchar(250) NOT NULL,
  `TCK_CT` varchar(250) NOT NULL,
  `PRINT` varchar(250) NOT NULL,
  `HC` time NOT NULL,
  `HA` time NOT NULL,
  `HABCAJ` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`idCF`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cfgrcn`
--

/*!40000 ALTER TABLE `cfgrcn` DISABLE KEYS */;
INSERT INTO `cfgrcn` (`idCF`,`TCK_VT`,`TCK_CT`,`PRINT`,`HC`,`HA`,`HABCAJ`) VALUES 
 (1,'F:\\Erick\\Documents\\Proyecto tutiendita New Version\\bin\\Debug\\ticket.rpt','F:\\Erick\\Documents\\Proyecto tutiendita New Version\\TckAbono.rpt','Adobe PDF','01:41:00','01:41:00',0);
/*!40000 ALTER TABLE `cfgrcn` ENABLE KEYS */;


--
-- Definition of table `clasificacion`
--

DROP TABLE IF EXISTS `clasificacion`;
CREATE TABLE `clasificacion` (
  `idClasif` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomClasif` varchar(45) NOT NULL,
  PRIMARY KEY (`idClasif`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clasificacion`
--

/*!40000 ALTER TABLE `clasificacion` DISABLE KEYS */;
INSERT INTO `clasificacion` (`idClasif`,`nomClasif`) VALUES 
 (0,' '),
 (1,'ABARROTES');
/*!40000 ALTER TABLE `clasificacion` ENABLE KEYS */;


--
-- Definition of table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `idCte` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `RFCCte` varchar(15) NOT NULL,
  `NomCte` varchar(45) NOT NULL,
  `DirCte` varchar(65) NOT NULL,
  `TelCte` varchar(20) NOT NULL,
  `Afiliacion` datetime NOT NULL,
  `ColCte` varchar(45) NOT NULL,
  `Poblacion` varchar(45) NOT NULL,
  `CPCte` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `idSuc` int(10) unsigned NOT NULL,
  PRIMARY KEY (`idCte`) USING BTREE,
  KEY `FKSuc1` (`idSuc`),
  CONSTRAINT `FKSuc1` FOREIGN KEY (`idSuc`) REFERENCES `sucursal` (`idSuc`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`idCte`,`RFCCte`,`NomCte`,`DirCte`,`TelCte`,`Afiliacion`,`ColCte`,`Poblacion`,`CPCte`,`email`,`idSuc`) VALUES 
 (1,'***************','MOSTRADOR','******************','XXXXXXXXXX','2014-06-01 00:00:00','************************','**************************','*******************','***************************',1),
 (2,'JKSDFDJSF','JUAN','DKASDK','661212','2014-06-23 00:22:52','KDKA','KDSK','27100','ERERW@HOTMAIL.COM',1);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;


--
-- Definition of table `compras`
--

DROP TABLE IF EXISTS `compras`;
CREATE TABLE `compras` (
  `CompraNum` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProv` int(10) unsigned NOT NULL,
  `idClasif` int(10) unsigned NOT NULL,
  `FecCompra` datetime NOT NULL,
  `TotalCompra` decimal(10,0) NOT NULL,
  PRIMARY KEY (`CompraNum`) USING BTREE,
  KEY `FKComp` (`idProv`),
  KEY `FKComp1` (`idClasif`),
  CONSTRAINT `FKComp` FOREIGN KEY (`idProv`) REFERENCES `proveedor` (`idProv`),
  CONSTRAINT `FKComp1` FOREIGN KEY (`idClasif`) REFERENCES `clasificacion` (`idClasif`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `compras`
--

/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;


--
-- Definition of table `detcompra`
--

DROP TABLE IF EXISTS `detcompra`;
CREATE TABLE `detcompra` (
  `CompraNum` int(10) unsigned NOT NULL,
  `idProd` int(10) unsigned NOT NULL,
  `CantCompra` decimal(10,0) NOT NULL,
  `PrecioCompra` decimal(10,0) NOT NULL,
  `ImporteCompra` decimal(10,0) NOT NULL,
  PRIMARY KEY (`CompraNum`,`idProd`),
  KEY `FK_DetCompra_2` (`idProd`),
  CONSTRAINT `FK_DetCompra_1` FOREIGN KEY (`CompraNum`) REFERENCES `compras` (`CompraNum`),
  CONSTRAINT `FK_DetCompra_2` FOREIGN KEY (`idProd`) REFERENCES `productos` (`idProd`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detcompra`
--

/*!40000 ALTER TABLE `detcompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detcompra` ENABLE KEYS */;


--
-- Definition of table `detvta`
--

DROP TABLE IF EXISTS `detvta`;
CREATE TABLE `detvta` (
  `idVenta` int(10) unsigned NOT NULL,
  `idProd` int(10) unsigned NOT NULL,
  `cantVta` decimal(10,0) NOT NULL,
  `PrecioUnit` decimal(10,0) NOT NULL,
  `importe` decimal(10,0) NOT NULL,
  `Descu` decimal(10,0) NOT NULL,
  PRIMARY KEY (`idVenta`,`idProd`) USING BTREE,
  KEY `DetVta4` (`idProd`) USING BTREE,
  CONSTRAINT `DetVta3` FOREIGN KEY (`idVenta`) REFERENCES `ventas` (`idVenta`),
  CONSTRAINT `DetVta4` FOREIGN KEY (`idProd`) REFERENCES `productos` (`idProd`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detvta`
--

/*!40000 ALTER TABLE `detvta` DISABLE KEYS */;
INSERT INTO `detvta` (`idVenta`,`idProd`,`cantVta`,`PrecioUnit`,`importe`,`Descu`) VALUES 
 (1,1,'1','15','50','0'),
 (2,1,'1','15','50','0'),
 (3,1,'1','15','50','0'),
 (3,2,'1','25','50','0'),
 (4,1,'1','15','100','0'),
 (4,2,'1','25','100','0'),
 (5,1,'1','15','20','0'),
 (6,2,'1','25','50','0'),
 (7,1,'1','15','50','0'),
 (8,2,'1','25','100','0'),
 (9,2,'1','25','60','0'),
 (10,2,'1','25','200','0'),
 (11,2,'1','25','40','0'),
 (12,2,'1','25','500','0'),
 (13,2,'1','25','0','0'),
 (14,1,'1','15','20','0'),
 (15,1,'1','15','20','0'),
 (16,1,'1','15','20','0'),
 (17,1,'1','15','20','0'),
 (18,1,'2','15','50','0'),
 (19,1,'1','15','20','0'),
 (20,1,'1','15','20','0'),
 (21,1,'1','15','20','0'),
 (22,1,'1','15','20','0'),
 (23,1,'1','15','30','0'),
 (24,1,'1','15','20','0'),
 (25,1,'1','15','20','0'),
 (26,1,'1','15','20','0'),
 (27,1,'1','15','30','0'),
 (28,1,'1','15','20','0'),
 (29,1,'1','15','20','0'),
 (30,1,'1','15','20','0'),
 (31,1,'1','15','20','0'),
 (32,1,'1','15','30','0'),
 (33,1,'1','15','0','0');
INSERT INTO `detvta` (`idVenta`,`idProd`,`cantVta`,`PrecioUnit`,`importe`,`Descu`) VALUES 
 (34,1,'1','15','0','0'),
 (35,1,'1','15','0','0'),
 (36,1,'1','15','0','0'),
 (37,1,'6','15','0','0');
/*!40000 ALTER TABLE `detvta` ENABLE KEYS */;


--
-- Definition of table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `idEmp` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomEmp` varchar(45) NOT NULL,
  `fecIngreso` date DEFAULT NULL,
  `domEmpl` varchar(45) NOT NULL,
  `telEmpe` varchar(15) NOT NULL,
  `idSuc` int(10) unsigned NOT NULL,
  `user` varchar(45) NOT NULL,
  `pwd` varchar(45) NOT NULL,
  `mstr` tinyint(3) unsigned DEFAULT '0',
  PRIMARY KEY (`idEmp`),
  KEY `FKEmp` (`idSuc`),
  CONSTRAINT `FKEmp` FOREIGN KEY (`idSuc`) REFERENCES `sucursal` (`idSuc`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;

--
-- Dumping data for table `empleados`
--

/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` (`idEmp`,`nomEmp`,`fecIngreso`,`domEmpl`,`telEmpe`,`idSuc`,`user`,`pwd`,`mstr`) VALUES 
 (1,'Erick','2014-05-01','ZZZZZZ','12345',1,'ERICK','99800b85d3383e3a2fb45eb7d0066a4879a9dad0',1),
 (2,'Adriana Pacheco','2014-05-05','Jimenez #431','123456',1,'ADRI','99800b85d3383e3a2fb45eb7d0066a4879a9dad0',0),
 (4,'JESUS GONZALEZ','2014-05-08','AV. XXXXX','39493400',1,'CHUCHO','7110eda4d09e062aa5e4a390b0a572ac0d2c0220',0);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;


--
-- Definition of table `gerente`
--

DROP TABLE IF EXISTS `gerente`;
CREATE TABLE `gerente` (
  `idgerente` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NomGer` varchar(45) NOT NULL,
  `RFCGer` varchar(15) NOT NULL,
  `FecIngreso` date NOT NULL,
  `domGer` varchar(45) NOT NULL,
  `telGer` varchar(15) NOT NULL,
  PRIMARY KEY (`idgerente`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gerente`
--

/*!40000 ALTER TABLE `gerente` DISABLE KEYS */;
INSERT INTO `gerente` (`idgerente`,`NomGer`,`RFCGer`,`FecIngreso`,`domGer`,`telGer`) VALUES 
 (0,' ',' ','1900-01-01',' ',' '),
 (14,'Erick','eeexxx','0000-00-00','lalala lala','12334');
/*!40000 ALTER TABLE `gerente` ENABLE KEYS */;


--
-- Definition of table `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `idClasif` int(10) unsigned NOT NULL,
  `idProd` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NomProd` varchar(45) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  `descrip` varchar(100) NOT NULL,
  `Precio` decimal(12,2) NOT NULL,
  `costo` decimal(12,2) NOT NULL,
  `Existencia` decimal(10,0) NOT NULL,
  `mini` int(10) unsigned NOT NULL,
  `Barcode` varchar(45) NOT NULL,
  `Ubicacion` varchar(15) DEFAULT NULL,
  `Unidad` varchar(15) NOT NULL,
  `idSuc` int(10) unsigned NOT NULL,
  `Descuent` int(10) unsigned DEFAULT '0',
  PRIMARY KEY (`idProd`) USING BTREE,
  KEY `FKClas` (`idClasif`),
  KEY `FKProd` (`idSuc`),
  CONSTRAINT `FKClas` FOREIGN KEY (`idClasif`) REFERENCES `clasificacion` (`idClasif`),
  CONSTRAINT `FKProd` FOREIGN KEY (`idSuc`) REFERENCES `sucursal` (`idSuc`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `productos`
--

/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` (`idClasif`,`idProd`,`NomProd`,`Marca`,`descrip`,`Precio`,`costo`,`Existencia`,`mini`,`Barcode`,`Ubicacion`,`Unidad`,`idSuc`,`Descuent`) VALUES 
 (1,1,'XXX','CCCC','CCC','14.40','12.50','68',2,'56898989','XXXX','Pieza',1,4),
 (1,2,'HHJJ','H','H','25.00','23.50','1',3,'4567890','HHHH','Pieza',1,0),
 (1,3,'7','8','8','15.00','12.50','1',10,'6','E','Pieza',1,0),
 (1,4,'X','XX','X','1000.00','1000.00','7',1,'90000','X','Pieza',1,0),
 (1,5,'X','X','X','1000.00','1000.00','11',2,'678ASAJSKSAM','X','Pieza',1,0);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;


--
-- Definition of table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `idProv` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NomProv` varchar(45) NOT NULL,
  `dirProv` varchar(45) NOT NULL,
  `TelProv` varchar(15) NOT NULL,
  `RFCProv` varchar(20) NOT NULL,
  `emailProve` varchar(25) NOT NULL,
  PRIMARY KEY (`idProv`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `proveedor`
--

/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` (`idProv`,`NomProv`,`dirProv`,`TelProv`,`RFCProv`,`emailProve`) VALUES 
 (0,' ',' ',' ',' ',' ');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;


--
-- Definition of table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
CREATE TABLE `sucursal` (
  `idSuc` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nomSuc` varchar(45) NOT NULL,
  `RFCSuc` varchar(20) NOT NULL,
  `direccion` varchar(60) NOT NULL,
  `idgerente` int(10) unsigned NOT NULL,
  `HC` datetime NOT NULL,
  `HA` datetime NOT NULL,
  PRIMARY KEY (`idSuc`),
  KEY `FKSuc` (`idgerente`),
  CONSTRAINT `FKSuc` FOREIGN KEY (`idgerente`) REFERENCES `gerente` (`idgerente`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sucursal`
--

/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
INSERT INTO `sucursal` (`idSuc`,`nomSuc`,`RFCSuc`,`direccion`,`idgerente`,`HC`,`HA`) VALUES 
 (1,'XXX','xxx890','Shalalala',14,'0000-00-00 00:00:00','0000-00-00 00:00:00');
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;


--
-- Definition of table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `User` char(32) NOT NULL,
  `Pwd` varchar(32) NOT NULL,
  PRIMARY KEY (`User`,`Pwd`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuario`
--

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`User`,`Pwd`) VALUES 
 ('',' ');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;


--
-- Definition of table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `idVenta` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fecVta` datetime NOT NULL,
  `totalVta` decimal(10,2) NOT NULL,
  `Tipopago` varchar(30) NOT NULL,
  `idEmp` int(10) unsigned NOT NULL,
  `idCte` int(10) unsigned NOT NULL,
  `importeLetra` varchar(65) NOT NULL,
  PRIMARY KEY (`idVenta`) USING BTREE,
  KEY `FKventas` (`idEmp`) USING BTREE,
  KEY `VentaFK` (`Tipopago`) USING BTREE,
  KEY `VentasFK_2` (`idCte`),
  CONSTRAINT `VentaFK_1` FOREIGN KEY (`idEmp`) REFERENCES `empleados` (`idEmp`),
  CONSTRAINT `VentasFK_2` FOREIGN KEY (`idCte`) REFERENCES `clientes` (`idCte`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ventas`
--

/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` (`idVenta`,`fecVta`,`totalVta`,`Tipopago`,`idEmp`,`idCte`,`importeLetra`) VALUES 
 (1,'2014-06-20 01:43:36','15.00','Efectivo',1,1,'(QUINCE PESOS)'),
 (2,'2014-06-22 23:31:01','40.00','Efectivo',1,1,'(CUARENTA PESOS)'),
 (3,'2014-06-22 23:56:27','40.00','Efectivo',1,1,'(CUARENTA PESOS)'),
 (4,'2014-06-22 23:57:41','40.00','Efectivo',1,1,'(CUARENTA PESOS)'),
 (5,'2014-06-23 00:00:47','15.00','Efectivo',1,1,'(QUINCE PESOS)'),
 (6,'2014-06-23 00:03:41','25.00','Efectivo',1,1,'(VEINTICINCO PESOS)'),
 (7,'2014-06-23 00:05:08','15.00','Efectivo',1,1,'(QUINCE PESOS)'),
 (8,'2014-06-23 00:05:23','25.00','Efectivo',1,1,'(VEINTICINCO PESOS)'),
 (9,'2014-06-23 00:08:12','25.00','Efectivo',1,1,'(VEINTICINCO PESOS)'),
 (10,'2014-06-23 00:09:54','25.00','Efectivo',1,1,'(VEINTICINCO PESOS)'),
 (11,'2014-06-23 00:11:58','25.00','Efectivo',1,1,'(VEINTICINCO PESOS)'),
 (12,'2014-06-23 00:15:41','25.00','Efectivo',1,1,'(VEINTICINCO PESOS)'),
 (13,'2014-06-23 00:23:08','25.00','Credito',1,2,'(VEINTICINCO PESOS)'),
 (14,'2014-08-22 15:45:45','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)');
INSERT INTO `ventas` (`idVenta`,`fecVta`,`totalVta`,`Tipopago`,`idEmp`,`idCte`,`importeLetra`) VALUES 
 (15,'2014-08-22 15:48:16','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (16,'2014-08-22 15:51:51','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (17,'2014-08-22 15:52:47','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (18,'2014-08-26 16:08:27','28.80','Efectivo',1,1,'(VEINTIOCHO PESOS CON OCHENTA CENTAVOS)'),
 (19,'2014-08-26 16:23:54','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (20,'2014-08-26 16:24:47','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (21,'2014-08-26 16:28:17','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (22,'2014-08-26 16:30:19','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (23,'2014-08-26 16:30:47','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (24,'2014-08-26 16:31:23','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (25,'2014-08-26 16:33:30','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)');
INSERT INTO `ventas` (`idVenta`,`fecVta`,`totalVta`,`Tipopago`,`idEmp`,`idCte`,`importeLetra`) VALUES 
 (26,'2014-08-26 16:35:26','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (27,'2014-08-26 16:35:45','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (28,'2014-08-26 16:36:24','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (29,'2014-08-26 16:39:10','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (30,'2014-08-26 16:39:31','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (31,'2014-08-26 16:45:42','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (32,'2014-08-26 17:36:46','14.40','Efectivo',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (33,'2014-08-26 18:23:40','14.40','Tarjeta de Credito',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (34,'2014-08-26 18:32:44','14.40','Tarjeta de Credito',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (35,'2014-08-26 18:37:04','14.40','Tarjeta de Credito',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)'),
 (36,'2014-08-26 18:38:25','14.40','Tarjeta de Credito',1,1,'(CATORCE PESOS CON CUARENTA CENTAVOS)');
INSERT INTO `ventas` (`idVenta`,`fecVta`,`totalVta`,`Tipopago`,`idEmp`,`idCte`,`importeLetra`) VALUES 
 (37,'2014-08-26 18:56:56','86.40','Tarjeta de Credito',1,1,'(OCHENTA Y SEIS PESOS CON CUARENTA CENTAVOS)');
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;


--
-- Definition of procedure `ProcClasificacion`
--

DROP PROCEDURE IF EXISTS `ProcClasificacion`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcClasificacion`(IN nomclasif varchar(45))
BEGIN
       Insert into clasificacion values(idClasif,nomClasif);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcClientes`
--

DROP PROCEDURE IF EXISTS `ProcClientes`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcClientes`(IN RFCCte varchar(15),IN NomCte varchar(45), IN DirCte varchar(65),IN colCte varchar(45), IN Poblacion varchar(45),IN CPCte varchar(45),In TelCte varchar(20), IN Afiliacion datetime, IN email varchar(45) )
BEGIN
Insert into clientes values (idCte, RFCCte, NomCte, DirCte, ColCte, Poblacion, CPCte, TelCte, Afiliacion, email);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcCompras`
--

DROP PROCEDURE IF EXISTS `ProcCompras`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcCompras`(IN  idProv int, IN idClasif int, IN FecCompra datetime, IN cantArt int, IN TotalCompra decimal)
BEGIN
Insert into compras values(CompraNum,idProv,idClasif,FecCompra,cantArt,TotalCompra);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcDetCompra`
--

DROP PROCEDURE IF EXISTS `ProcDetCompra`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcDetCompra`(IN CompraNum int, IN idProd int, IN CantCompra decimal, IN PrecioCompra decimal, IN ImporteCompra decimal)
BEGIN
Insert into detcomp values (CompraNum, idProd, CantCompra, PrecioCompra, ImporteCompra);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcDetVta`
--

DROP PROCEDURE IF EXISTS `ProcDetVta`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcDetVta`(IN idVenta int, IN idProd int,IN cantVta decimal(10,0), IN PrecioUnit decimal(10,0), IN importe decimal(10,0),IN Descu decimal(10,0))
BEGIN
Insert into detvta values(idVenta, idProd, cantVta, PrecioUnit, importe, Descu);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcEmpleados`
--

DROP PROCEDURE IF EXISTS `ProcEmpleados`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcEmpleados`(IN nomEmp varchar(45), IN fecIngreso date, IN domEmpl varchar(45), IN telEmpe varchar(15), IN idSuc int)
BEGIN
Insert into empleados values (idEmp, nomEmp, fecIngreso, domEmpl, telEmpe,idSuc);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcGerente`
--

DROP PROCEDURE IF EXISTS `ProcGerente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcGerente`(IN NomGer varchar(45),IN RFCGer varchar(15), IN FecIngreso date, IN domGer varchar(45), IN telGer varchar(15))
BEGIN
Insert into gerente values(idgerente, NomGer, RFCGer, FecIngreso, domGer, telGer);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcModifCliente`
--

DROP PROCEDURE IF EXISTS `ProcModifCliente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcModifCliente`(IN idCte1 int, IN RFCCte1 varchar(15),IN NomCte1 varchar(45), IN DirCte1 varchar(65),IN ColCte1 varchar(45), IN Poblacion1 varchar(45),IN CPCte1 varchar(45),In TelCte1 varchar(20), IN Afiliacion1 datetime, IN email1 varchar(45),IN idSuc1 int)
BEGIN
    Update cliente set RFC=RFC1,Nomcte=NomCte1,DirCte=DirCte1,ColCte=ColCte1,Poblacion=Poblacion1,CPCte=CPCte1,TelCte=TelCte1,Afiliacion=Afiliacion1,email=email1,idSuc=idSuc1
    where idCte=idCte1;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraAbono`
--

DROP PROCEDURE IF EXISTS `ProcMuestraAbono`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraAbono`()
BEGIN
     Select * From vistaabono;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraClas`
--

DROP PROCEDURE IF EXISTS `ProcMuestraClas`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraClas`()
BEGIN
   Select * From vistaclasificacion;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraClientes`
--

DROP PROCEDURE IF EXISTS `ProcMuestraClientes`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraClientes`()
BEGIN
    Select * From vistaclientes;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraDetVta`
--

DROP PROCEDURE IF EXISTS `ProcMuestraDetVta`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraDetVta`()
BEGIN
    Select * From vistadetvta;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraEmpleados`
--

DROP PROCEDURE IF EXISTS `ProcMuestraEmpleados`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraEmpleados`()
BEGIN
       select * from vistaempleado;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraGerente`
--

DROP PROCEDURE IF EXISTS `ProcMuestraGerente`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraGerente`()
BEGIN
    Select * From vistagerente;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraInventario`
--

DROP PROCEDURE IF EXISTS `ProcMuestraInventario`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraInventario`()
BEGIN
   Select * From vistainventario;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraProveedor`
--

DROP PROCEDURE IF EXISTS `ProcMuestraProveedor`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraProveedor`()
BEGIN
      select * from vistaproveedor;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraReporteCaja`
--

DROP PROCEDURE IF EXISTS `ProcMuestraReporteCaja`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraReporteCaja`()
BEGIN
       Select * From vistareportecaja;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraReporteCredito`
--

DROP PROCEDURE IF EXISTS `ProcMuestraReporteCredito`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraReporteCredito`()
BEGIN
        select * from vistareportecredito;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestraReporteTarjeta`
--

DROP PROCEDURE IF EXISTS `ProcMuestraReporteTarjeta`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestraReporteTarjeta`()
BEGIN
      select * From vistareportetarjeta;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcMuestravistacom`
--

DROP PROCEDURE IF EXISTS `ProcMuestravistacom`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcMuestravistacom`()
BEGIN
  select * from vistacompras;
END $$

DELIMITER ;

--
-- Definition of procedure `ProcProductos`
--

DROP PROCEDURE IF EXISTS `ProcProductos`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcProductos`(IN idClasif int,IN idSuc int,IN NomProd varchar(45), IN Marca varchar(45), IN descrip varchar(100), IN Precio decimal(12,2), IN costo decimal(12,2), IN Existencia decimal(10,0), IN mini int, IN Barcode varchar(45), IN Ubicacion varchar(15), IN Unidad varchar(15))
BEGIN
Insert into productos values(idClasif, idProd,NomProd, Marca, descrip, Precio, costo, Existencia, mini, Barcode, Ubicacion, Unidad,idSuc);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcProveedor`
--

DROP PROCEDURE IF EXISTS `ProcProveedor`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcProveedor`(IN NomProv varchar(45), IN RFCProv varchar(20), IN dirProv varchar(45), IN TelProv varchar(15), IN emailProve varchar(25))
BEGIN
Insert into proveedor values (idProv, NomProv, RFCProv, dirProv, TelProv, emailProve);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcSucursal`
--

DROP PROCEDURE IF EXISTS `ProcSucursal`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcSucursal`(IN nomSuc varchar(45), IN RFCSuc varchar(20),IN direccion varchar(60), IN idgerente int)
BEGIN
Insert into sucursal values(idSuc, nomSuc, RFCSuc, direccion, idgerente);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcUsuario`
--

DROP PROCEDURE IF EXISTS `ProcUsuario`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcUsuario`(in User char(32), in Pwd varchar(32))
BEGIN
    Insert into usuario values (User, Pwd);
END $$

DELIMITER ;

--
-- Definition of procedure `ProcVentas`
--

DROP PROCEDURE IF EXISTS `ProcVentas`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcVentas`(IN `fecVta` DATETIME, IN `totalVta` DECIMAL, IN `Tipopago` VARCHAR(30), IN `idEmp` INT, IN `idCte` INT, IN `importeLetra` VARCHAR(65))
BEGIN
Insert into ventas values(idVenta, idEmp, idCte, fecVta, totalVta, importeLetra, Tipopago);
END $$

DELIMITER ;

--
-- Definition of procedure `ReporteDeduccion`
--

DROP PROCEDURE IF EXISTS `ReporteDeduccion`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReporteDeduccion`()
BEGIN
     Select Sum(totalVta)
     From   ventas
     where Tipopago like '%Credito%';
END $$

DELIMITER ;

--
-- Definition of procedure `ReportePercepcion`
--

DROP PROCEDURE IF EXISTS `ReportePercepcion`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReportePercepcion`()
BEGIN
     Select Sum(v.totalVta) + Sum(a.Abono)
     From ventas v, abono a
     where v.Tipopago like '%Efectivo%' or v.Tipopago like '%Tarjeta%' and a.Abono>0;
END $$

DELIMITER ;

--
-- Definition of procedure `SumaAlmacen`
--

DROP PROCEDURE IF EXISTS `SumaAlmacen`;

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SumaAlmacen`()
BEGIN
      select SUM(p.Existencia) + SUM(d.CantCompra)
      From productos p, detcompra d
      where p.idProd = d.idProd;
END $$

DELIMITER ;

--
-- Definition of view `general`
--

DROP TABLE IF EXISTS `general`;
DROP VIEW IF EXISTS `general`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `general` AS select `v`.`idVenta` AS `idVenta`,`c`.`NomCte` AS `NomCte`,`v`.`fecVta` AS `fecVta`,`v`.`totalVta` AS `totalVta`,`v`.`Tipopago` AS `Tipopago` from (`ventas` `v` join `clientes` `c`) where (`v`.`idCte` = `c`.`idCte`);

--
-- Definition of view `vistaabono`
--

DROP TABLE IF EXISTS `vistaabono`;
DROP VIEW IF EXISTS `vistaabono`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaabono` AS select `c`.`NomCte` AS `NomCte`,`a`.`FecAbono` AS `FecAbono`,`a`.`Abono` AS `Abono`,`a`.`Saldo` AS `Saldo` from (`clientes` `c` join `abono` `a`) where (`c`.`idCte` = `a`.`idCte`);

--
-- Definition of view `vistaagotados`
--

DROP TABLE IF EXISTS `vistaagotados`;
DROP VIEW IF EXISTS `vistaagotados`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaagotados` AS select `productos`.`NomProd` AS `NomProd`,`productos`.`Marca` AS `Marca`,`productos`.`descrip` AS `descrip`,`productos`.`Existencia` AS `existencia` from `productos` where (`productos`.`Existencia` < `productos`.`mini`);

--
-- Definition of view `vistaclasificacion`
--

DROP TABLE IF EXISTS `vistaclasificacion`;
DROP VIEW IF EXISTS `vistaclasificacion`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaclasificacion` AS select `clasificacion`.`idClasif` AS `idClasif`,`clasificacion`.`nomClasif` AS `nomClasif` from `clasificacion`;

--
-- Definition of view `vistaclientes`
--

DROP TABLE IF EXISTS `vistaclientes`;
DROP VIEW IF EXISTS `vistaclientes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaclientes` AS select `clientes`.`idCte` AS `idCte`,`clientes`.`RFCCte` AS `RFCCte`,`clientes`.`NomCte` AS `NomCte`,`clientes`.`DirCte` AS `DirCte`,`clientes`.`ColCte` AS `ColCte`,`clientes`.`CPCte` AS `CPCte`,`clientes`.`Poblacion` AS `Poblacion`,`clientes`.`TelCte` AS `TelCte`,`clientes`.`Afiliacion` AS `Afiliacion`,`clientes`.`email` AS `email` from `clientes`;

--
-- Definition of view `vistadetvta`
--

DROP TABLE IF EXISTS `vistadetvta`;
DROP VIEW IF EXISTS `vistadetvta`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistadetvta` AS select `d`.`idVenta` AS `idVenta`,`p`.`NomProd` AS `NomProd`,`d`.`cantVta` AS `cantVta`,`d`.`PrecioUnit` AS `PrecioUnit`,`v`.`totalVta` AS `totalVta` from ((`detvta` `d` join `ventas` `v`) join `productos` `p`) where ((`v`.`idVenta` = `d`.`idVenta`) and (`d`.`idProd` = `p`.`idProd`));

--
-- Definition of view `vistaempleado`
--

DROP TABLE IF EXISTS `vistaempleado`;
DROP VIEW IF EXISTS `vistaempleado`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaempleado` AS select `empleados`.`nomEmp` AS `nomEmp`,`empleados`.`fecIngreso` AS `fecIngreso`,`empleados`.`domEmpl` AS `domEmpl`,`empleados`.`telEmpe` AS `telEmpe` from `empleados`;

--
-- Definition of view `vistagerente`
--

DROP TABLE IF EXISTS `vistagerente`;
DROP VIEW IF EXISTS `vistagerente`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistagerente` AS select `gerente`.`NomGer` AS `NomGer`,`gerente`.`FecIngreso` AS `FecIngreso`,`gerente`.`domGer` AS `domGer`,`gerente`.`telGer` AS `telGer`,`gerente`.`RFCGer` AS `RFCGer` from `gerente`;

--
-- Definition of view `vistainventario`
--

DROP TABLE IF EXISTS `vistainventario`;
DROP VIEW IF EXISTS `vistainventario`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistainventario` AS select `productos`.`Barcode` AS `Barcode`,`productos`.`NomProd` AS `NomProd`,`productos`.`Marca` AS `Marca`,`productos`.`descrip` AS `descrip`,`productos`.`Ubicacion` AS `Ubicacion`,`productos`.`Existencia` AS `Existencia`,`productos`.`costo` AS `costo`,`productos`.`Descuent` AS `Descuent` from `productos`;

--
-- Definition of view `vistaproducto`
--

DROP TABLE IF EXISTS `vistaproducto`;
DROP VIEW IF EXISTS `vistaproducto`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaproducto` AS (select `productos`.`Barcode` AS `Barcode`,`productos`.`NomProd` AS `NomProd`,`productos`.`descrip` AS `descrip`,`productos`.`Marca` AS `Marca`,`productos`.`Precio` AS `Precio`,`productos`.`Existencia` AS `Existencia`,`productos`.`Unidad` AS `Unidad`,`productos`.`Ubicacion` AS `Ubicacion` from `productos`);

--
-- Definition of view `vistaproveedor`
--

DROP TABLE IF EXISTS `vistaproveedor`;
DROP VIEW IF EXISTS `vistaproveedor`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistaproveedor` AS select `proveedor`.`NomProv` AS `NomProv`,`proveedor`.`dirProv` AS `dirProv`,`proveedor`.`TelProv` AS `TelProv`,`proveedor`.`RFCProv` AS `RFCProv`,`proveedor`.`emailProve` AS `emailProve` from `proveedor`;

--
-- Definition of view `vistareportecaja`
--

DROP TABLE IF EXISTS `vistareportecaja`;
DROP VIEW IF EXISTS `vistareportecaja`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistareportecaja` AS select `v`.`idVenta` AS `idVenta`,`c`.`NomCte` AS `NomCte`,`v`.`fecVta` AS `fecVta`,`v`.`totalVta` AS `totalVta`,`v`.`Tipopago` AS `Tipopago` from (`ventas` `v` join `clientes` `c`) where ((`v`.`idCte` = `c`.`idCte`) and (`v`.`Tipopago` = 'Efectivo'));

--
-- Definition of view `vistareportecredito`
--

DROP TABLE IF EXISTS `vistareportecredito`;
DROP VIEW IF EXISTS `vistareportecredito`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistareportecredito` AS select `v`.`idVenta` AS `idVenta`,`c`.`NomCte` AS `NomCte`,`v`.`fecVta` AS `fecVta`,`v`.`totalVta` AS `totalVta`,`v`.`Tipopago` AS `Tipopago` from (`ventas` `v` join `clientes` `c`) where ((`v`.`idCte` = `c`.`idCte`) and (`v`.`Tipopago` = 'Credito'));

--
-- Definition of view `vistareportetarjeta`
--

DROP TABLE IF EXISTS `vistareportetarjeta`;
DROP VIEW IF EXISTS `vistareportetarjeta`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vistareportetarjeta` AS select `v`.`idVenta` AS `idVenta`,`c`.`NomCte` AS `NomCte`,`v`.`fecVta` AS `fecVta`,`v`.`totalVta` AS `totalVta`,`v`.`Tipopago` AS `Tipopago` from (`ventas` `v` join `clientes` `c`) where ((`v`.`idCte` = `c`.`idCte`) and (`v`.`Tipopago` like '%Tarjeta%'));



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
