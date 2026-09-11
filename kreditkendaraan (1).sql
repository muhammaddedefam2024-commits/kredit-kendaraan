-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 05, 2026 at 10:44 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kreditkendaraan`
--

-- --------------------------------------------------------

--
-- Table structure for table `angsuran`
--

CREATE TABLE `angsuran` (
  `AngsuranID` int(11) NOT NULL,
  `KreditID` int(11) NOT NULL,
  `AngsuranKe` int(11) DEFAULT NULL,
  `JatuhTempo` date DEFAULT NULL,
  `JumlahAngsuran` decimal(18,2) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerID` int(11) NOT NULL,
  `NIK` varchar(20) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) DEFAULT NULL,
  `NoHP` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `kendaraan`
--

CREATE TABLE `kendaraan` (
  `KendaraanID` int(11) NOT NULL,
  `NoPolisi` varchar(15) NOT NULL,
  `Merk` varchar(50) NOT NULL,
  `Tipe` varchar(50) NOT NULL,
  `Tahun` int(11) DEFAULT NULL,
  `Harga` decimal(18,2) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `kredit`
--

CREATE TABLE `kredit` (
  `KreditID` int(11) NOT NULL,
  `NoKredit` varchar(30) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `KendaraanID` int(11) NOT NULL,
  `TanggalKredit` date DEFAULT NULL,
  `HargaKendaraan` decimal(18,2) DEFAULT NULL,
  `DP` decimal(18,2) DEFAULT NULL,
  `PokokKredit` decimal(18,2) DEFAULT NULL,
  `Bunga` decimal(5,2) DEFAULT NULL,
  `Tenor` int(11) DEFAULT NULL,
  `AngsuranPerBulan` decimal(18,2) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pembayaran`
--

CREATE TABLE `pembayaran` (
  `PembayaranID` int(11) NOT NULL,
  `AngsuranID` int(11) NOT NULL,
  `TanggalBayar` date DEFAULT NULL,
  `JumlahBayar` decimal(18,2) DEFAULT NULL,
  `Denda` decimal(18,2) DEFAULT NULL,
  `TotalBayar` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id_role` int(11) NOT NULL,
  `role_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id_role`, `role_name`) VALUES
(1, 'Admin'),
(2, 'User'),
(3, 'Master');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `idtrans` int(11) NOT NULL,
  `Pelanggan` varchar(100) NOT NULL,
  `Kendaraan` varchar(100) NOT NULL,
  `Harga` int(11) NOT NULL,
  `DP` int(11) NOT NULL,
  `Sisa_kredit` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`idtrans`, `Pelanggan`, `Kendaraan`, `Harga`, `DP`, `Sisa_kredit`) VALUES
(1, 'Dede', 'Vario 150', 30000000, 10000000, 20000000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID_user` int(11) NOT NULL,
  `Nama_Lengkap` varchar(100) NOT NULL,
  `ussername` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `id_role` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID_user`, `Nama_Lengkap`, `ussername`, `password`, `id_role`) VALUES
(10, '2', '2', '2', '2'),
(11, 'Dede', '1', '1', '1'),
(13, 'Dede', 'A', 'A', '1'),
(15, 'qwqw', '3', '3', '2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `angsuran`
--
ALTER TABLE `angsuran`
  ADD PRIMARY KEY (`AngsuranID`),
  ADD KEY `KreditID` (`KreditID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `kendaraan`
--
ALTER TABLE `kendaraan`
  ADD PRIMARY KEY (`KendaraanID`);

--
-- Indexes for table `kredit`
--
ALTER TABLE `kredit`
  ADD PRIMARY KEY (`KreditID`),
  ADD KEY `CustomerID` (`CustomerID`),
  ADD KEY `KendaraanID` (`KendaraanID`);

--
-- Indexes for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD PRIMARY KEY (`PembayaranID`),
  ADD KEY `AngsuranID` (`AngsuranID`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id_role`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`idtrans`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `angsuran`
--
ALTER TABLE `angsuran`
  MODIFY `AngsuranID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kendaraan`
--
ALTER TABLE `kendaraan`
  MODIFY `KendaraanID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kredit`
--
ALTER TABLE `kredit`
  MODIFY `KreditID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pembayaran`
--
ALTER TABLE `pembayaran`
  MODIFY `PembayaranID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id_role` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `idtrans` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `angsuran`
--
ALTER TABLE `angsuran`
  ADD CONSTRAINT `angsuran_ibfk_1` FOREIGN KEY (`KreditID`) REFERENCES `kredit` (`KreditID`);

--
-- Constraints for table `kredit`
--
ALTER TABLE `kredit`
  ADD CONSTRAINT `kredit_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`),
  ADD CONSTRAINT `kredit_ibfk_2` FOREIGN KEY (`KendaraanID`) REFERENCES `kendaraan` (`KendaraanID`);

--
-- Constraints for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD CONSTRAINT `pembayaran_ibfk_1` FOREIGN KEY (`AngsuranID`) REFERENCES `angsuran` (`AngsuranID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
