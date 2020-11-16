/*
SQLyog Ultimate v13.1.1 (64 bit)
MySQL - 8.0.19 : Database - finallab2
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`finallab2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `finallab2`;

/*Table structure for table `administrador` */

DROP TABLE IF EXISTS `administrador`;

CREATE TABLE `administrador` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `dni` varchar(15) DEFAULT NULL,
  `usuario` varchar(20) NOT NULL,
  `contraseña` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `administrador` */

/*Table structure for table `autor` */

DROP TABLE IF EXISTS `autor`;

CREATE TABLE `autor` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `autor` */

insert  into `autor`(`id`,`nombre`,`apellido`) values 
(1,'Matias','Lunaa'),
(2,'Constanza','Uno');

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `apellido` varchar(20) DEFAULT NULL,
  `domicilio` varchar(50) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `fechaNacimiento` date DEFAULT NULL,
  `dni` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `clientes` */

insert  into `clientes`(`id`,`nombre`,`apellido`,`domicilio`,`telefono`,`fechaNacimiento`,`dni`) values 
(1,'Constanzaa','Unoo','Sanma 1922','2615676357','2000-03-10','42562478'),
(2,'Constanza','Uno','Sanma 1922','2615676357','2000-03-10','42562478'),
(3,'Constanza','Uno','Sanma 1922','2615676357','2000-03-10','41659894');

/*Table structure for table `libros` */

DROP TABLE IF EXISTS `libros`;

CREATE TABLE `libros` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(30) DEFAULT NULL,
  `edicion` varchar(10) DEFAULT NULL,
  `lugarPublicacion` varchar(30) DEFAULT NULL,
  `año` date DEFAULT NULL,
  `paginas` int DEFAULT NULL,
  `isbn` varchar(17) DEFAULT NULL,
  `fk_autor` int DEFAULT NULL,
  `descripcion` text,
  PRIMARY KEY (`id`),
  KEY `fk_autor` (`fk_autor`),
  CONSTRAINT `fk_autor` FOREIGN KEY (`fk_autor`) REFERENCES `autor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `libros` */

insert  into `libros`(`id`,`titulo`,`edicion`,`lugarPublicacion`,`año`,`paginas`,`isbn`,`fk_autor`,`descripcion`) values 
(3,'Principito','1','Argentina','2020-11-11',511,'9789381753422',1,'The best libro ever'),
(4,'Principito','1','Argentina','2020-11-11',511,'9789381753422',1,'The best libro ever');

/*Table structure for table `prestamos` */

DROP TABLE IF EXISTS `prestamos`;

CREATE TABLE `prestamos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fk_cliente` int DEFAULT NULL,
  `fk_libro` int DEFAULT NULL,
  `fechaPrestamo` datetime DEFAULT NULL,
  `fechaDevolucion` datetime DEFAULT NULL,
  `devuelto` varchar(1) DEFAULT NULL,
  `fk_administrador` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_cliente` (`fk_cliente`),
  KEY `fk_libro` (`fk_libro`),
  KEY `fk_administrador` (`fk_administrador`),
  CONSTRAINT `fk_administrador` FOREIGN KEY (`fk_administrador`) REFERENCES `administrador` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_cliente` FOREIGN KEY (`fk_cliente`) REFERENCES `clientes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_libro` FOREIGN KEY (`fk_libro`) REFERENCES `libros` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `prestamos` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
