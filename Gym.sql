-- --------------------------------------------------------
-- Host:                         gara.ddns.net
-- Versión del servidor:         12.3.2-MariaDB - MariaDB Server
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.20.0.7320
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para gestiongimnasio
CREATE DATABASE IF NOT EXISTS `gestiongimnasio` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `gestiongimnasio`;

-- Volcando estructura para tabla gestiongimnasio.activos
CREATE TABLE IF NOT EXISTS `activos` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  `estado` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `numSerie` varchar(50) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `idSede` int(11) NOT NULL,
  `nota1` varchar(50) NOT NULL,
  `nota2` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `idSede` (`idSede`),
  CONSTRAINT `idSede` FOREIGN KEY (`idSede`) REFERENCES `sede` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.activos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla gestiongimnasio.perfiles
CREATE TABLE IF NOT EXISTS `perfiles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.perfiles: ~3 rows (aproximadamente)
INSERT INTO `perfiles` (`Id`, `descripcion`) VALUES
	(1, 'Admin'),
	(2, 'Empleado'),
	(3, 'Socio');

-- Volcando estructura para tabla gestiongimnasio.plan
CREATE TABLE IF NOT EXISTS `plan` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `precio` double NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `sedeId` int(11) NOT NULL,
  `nota1` varchar(50) NOT NULL,
  `nota2` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `sedeId` (`sedeId`),
  CONSTRAINT `sedeId` FOREIGN KEY (`sedeId`) REFERENCES `sede` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.plan: ~0 rows (aproximadamente)

-- Volcando estructura para tabla gestiongimnasio.relacionplanusuario
CREATE TABLE IF NOT EXISTS `relacionplanusuario` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` datetime DEFAULT NULL,
  `precio` double NOT NULL,
  `sedeId` int(11) NOT NULL,
  `planesId` int(11) NOT NULL DEFAULT 0,
  `usuarioId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `sedeId` (`sedeId`),
  KEY `planesId` (`planesId`),
  KEY `usuarioId` (`usuarioId`),
  CONSTRAINT `planesId` FOREIGN KEY (`planesId`) REFERENCES `plan` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `sedeId` FOREIGN KEY (`sedeId`) REFERENCES `sede` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `usuarioId` FOREIGN KEY (`usuarioId`) REFERENCES `usuarios` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.relacionplanusuario: ~0 rows (aproximadamente)

-- Volcando estructura para tabla gestiongimnasio.sede
CREATE TABLE IF NOT EXISTS `sede` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `jerarquia` int(11) NOT NULL,
  `capacidad` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.sede: ~0 rows (aproximadamente)

-- Volcando estructura para tabla gestiongimnasio.sueldos
CREATE TABLE IF NOT EXISTS `sueldos` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `fechaPago` datetime NOT NULL,
  `importe` float NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `DNI` int(11) NOT NULL,
  `sexo` char(50) NOT NULL,
  `CUIL` varchar(50) NOT NULL,
  `estado` varchar(50) NOT NULL,
  `CBU` varchar(50) NOT NULL,
  `alias` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.sueldos: ~0 rows (aproximadamente)

-- Volcando estructura para tabla gestiongimnasio.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `DNI` int(11) NOT NULL,
  `sexo` char(50) DEFAULT NULL,
  `observaciones` varchar(50) DEFAULT NULL,
  `perfil` int(11) NOT NULL,
  `nota1` varchar(50) DEFAULT NULL,
  `nota2` varchar(50) DEFAULT NULL,
  `usuLogin` varchar(50) DEFAULT NULL,
  `usuPsw` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `perfil` (`perfil`),
  CONSTRAINT `perfil` FOREIGN KEY (`perfil`) REFERENCES `perfiles` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla gestiongimnasio.usuarios: ~0 rows (aproximadamente)

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
