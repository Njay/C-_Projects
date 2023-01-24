-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 19, 2023 at 08:36 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `pemesan`
--

CREATE TABLE `pemesan` (
  `no_kamar` int(4) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `tgl_booking` varchar(12) NOT NULL,
  `jenis_kamar` varchar(20) NOT NULL,
  `lama_menginap` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pemesan`
--

INSERT INTO `pemesan` (`no_kamar`, `nama`, `no_telp`, `alamat`, `tgl_booking`, `jenis_kamar`, `lama_menginap`) VALUES
(201, 'Panji', '08889990', 'Adiwerna', '19/01/2023', 'KANKER', 'System.Win'),
(202, 'kokoh', '08889990', 'suradadi', '23/01/2023', 'HEMAT', 'System.Win'),
(203, 'SUUUUUUHAR', '08889990', 'KALIMATI', '31/01/2023', 'VVIP', 'System.Win'),
(204, 'IQBAALE', '911', 'SLAWI', '31/01/2023', 'STANDART', 'System.Win'),
(205, 'ULYAAA AYYUHAL KAFIRUN', '666', 'slawi kulon', '28/01/2023', 'VIP', 'System.Win'),
(206, 'Dani Danger', '777', 'Wanasari', '19/01/2023', 'KANKER', 'System.Win');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pemesan`
--
ALTER TABLE `pemesan`
  ADD PRIMARY KEY (`no_kamar`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
