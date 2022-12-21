-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2022 at 03:54 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_mahasiswa`
--

-- --------------------------------------------------------

--
-- Table structure for table `mhs`
--

CREATE TABLE `mhs` (
  `nim` int(12) NOT NULL,
  `nama` varchar(30) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `jeniskelamin` varchar(10) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `kelas` varchar(10) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL,
  `alamat` varchar(100) CHARACTER SET latin1 COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mhs`
--

INSERT INTO `mhs` (`nim`, `nama`, `jeniskelamin`, `kelas`, `alamat`) VALUES
(21041001, 'Panji Arief Pratama', 'cowo', '3E', 'Slawi, Kab Tegal'),
(21041009, 'Asyraf Iqbal Oktavian', 'cowo', '3E', 'Slawi, Kab Tegal'),
(21041029, 'Mohamad Suharyadi', 'cowo', '3E', 'Kota Tegal'),
(21041075, 'Himmatul Ulya ', 'cewe', '3E', 'Procot, Kab Tegal'),
(21041086, 'Mufasirin', 'cowo', '3E', 'Suradadi, Kab Tegal');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mhs`
--
ALTER TABLE `mhs`
  ADD PRIMARY KEY (`nim`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
