CREATE DATABASE  IF NOT EXISTS `7_pdv_estoque` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `7_pdv_estoque`;
-- MySQL dump 10.13  Distrib 5.5.9, for Win32 (x86)
--
-- Host: localhost    Database: 7_pdv_estoque
-- ------------------------------------------------------
-- Server version	5.5.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `prod_for`
--

DROP TABLE IF EXISTS `prod_for`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prod_for` (
  `idProduto` int(10) unsigned NOT NULL,
  `idFornecedor` int(10) unsigned NOT NULL,
  `QTD` int(11) DEFAULT NULL,
  `QTD_Loja` int(11) DEFAULT NULL,
  `PrecoCusto` double DEFAULT NULL,
  `PrecoVenda` double DEFAULT NULL,
  `CDB` varchar(45) DEFAULT NULL,
  `Foto` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idProduto`,`idFornecedor`),
  KEY `fk_Produtos_has_Fornecedores_Fornecedores1` (`idFornecedor`),
  KEY `fk_Produtos_has_Fornecedores_Produtos1` (`idProduto`),
  CONSTRAINT `fk_Produtos_has_Fornecedores_Fornecedores1` FOREIGN KEY (`idFornecedor`) REFERENCES `fornecedores` (`idFornecedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produtos_has_Fornecedores_Produtos1` FOREIGN KEY (`idProduto`) REFERENCES `produtos` (`idProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prod_for`
--

LOCK TABLES `prod_for` WRITE;
/*!40000 ALTER TABLE `prod_for` DISABLE KEYS */;
/*!40000 ALTER TABLE `prod_for` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-02-06 23:20:22
