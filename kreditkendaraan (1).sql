-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 06, 2026
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
SET FOREIGN_KEY_CHECKS = 0;

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kreditkendaraan`
--

-- ========================================================
-- HAPUS TABEL LAMA JIKA ADA (urutan: anak dulu, baru induk)
-- ========================================================

DROP TABLE IF EXISTS `transaksi`;
DROP TABLE IF EXISTS `user`;
DROP TABLE IF EXISTS `kendaraan`;
DROP TABLE IF EXISTS `role`;

-- ========================================================
-- 1. TABEL role
-- ========================================================

CREATE TABLE `role` (
  `id_role` int(11) NOT NULL AUTO_INCREMENT,
  `role_name` varchar(100) NOT NULL,
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `role` (`id_role`, `role_name`) VALUES
(1, 'Admin'),
(2, 'User'),
(3, 'Master');

-- ========================================================
-- 2. TABEL user  (id_role INT → FK ke role)
-- ========================================================

CREATE TABLE `user` (
  `ID_user` int(11) NOT NULL AUTO_INCREMENT,
  `Nama_Lengkap` varchar(100) NOT NULL,
  `ussername` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `id_role` int(11) NOT NULL DEFAULT 2,
  PRIMARY KEY (`ID_user`),
  KEY `fk_user_role` (`id_role`),
  CONSTRAINT `fk_user_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `user` (`ID_user`, `Nama_Lengkap`, `ussername`, `password`, `id_role`) VALUES
(11, 'Dede',  '1', '1', 1),
(13, 'Admin', 'A', 'A', 1),
(15, 'qwqw',  '3', '3', 2);

-- ========================================================
-- 3. TABEL kendaraan
-- ========================================================

CREATE TABLE `kendaraan` (
  `KendaraanID` int(11) NOT NULL AUTO_INCREMENT,
  `NoPolisi` varchar(15) NOT NULL,
  `Merk` varchar(50) NOT NULL,
  `Tipe` varchar(50) NOT NULL,
  `Tahun` int(11) DEFAULT NULL,
  `Harga` decimal(18,2) DEFAULT NULL,
  `Status` varchar(20) DEFAULT 'Tersedia',
  PRIMARY KEY (`KendaraanID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `kendaraan` (`KendaraanID`, `NoPolisi`, `Merk`, `Tipe`, `Tahun`, `Harga`, `Status`) VALUES
(1,  'B 1234 ABC', 'Honda',      'Vario 125',         2022, 22500000.00,  'Tersedia'),
(2,  'B 2345 BCD', 'Honda',      'Vario 150',         2023, 25000000.00,  'Tersedia'),
(3,  'B 3456 CDE', 'Honda',      'Beat Street',       2022, 19500000.00,  'Tersedia'),
(4,  'B 4567 DEF', 'Honda',      'Scoopy',            2023, 22000000.00,  'Tersedia'),
(5,  'B 5678 EFG', 'Honda',      'PCX 160',           2023, 32000000.00,  'Tersedia'),
(6,  'B 6789 FGH', 'Yamaha',     'NMAX 155',          2023, 33500000.00,  'Tersedia'),
(7,  'B 7890 GHI', 'Yamaha',     'Aerox 155',         2022, 29500000.00,  'Tersedia'),
(8,  'B 8901 HIJ', 'Yamaha',     'Mio M3 125',        2022, 18500000.00,  'Tersedia'),
(9,  'B 9012 IJK', 'Yamaha',     'Lexi S 125',        2023, 24000000.00,  'Tersedia'),
(10, 'B 0123 JKL', 'Suzuki',     'Address 125',       2022, 19000000.00,  'Tersedia'),
(11, 'D 1111 AAA', 'Honda',      'Revo Fit',          2021, 17500000.00,  'Tersedia'),
(12, 'D 2222 BBB', 'Kawasaki',   'KLX 150',           2022, 35000000.00,  'Tersedia'),
(13, 'D 3333 CCC', 'Toyota',     'Avanza 1.3 G',      2022, 218000000.00, 'Tersedia'),
(14, 'D 4444 DDD', 'Toyota',     'Rush TRD Sportivo', 2023, 265000000.00, 'Tersedia'),
(15, 'D 5555 EEE', 'Honda',      'Brio Satya E CVT',  2023, 175000000.00, 'Tersedia'),
(16, 'D 6666 FFF', 'Daihatsu',   'Sigra X AT',        2022, 158000000.00, 'Tersedia'),
(17, 'D 7777 GGG', 'Suzuki',     'Ertiga GL AT',      2022, 255000000.00, 'Tersedia'),
(18, 'D 8888 HHH', 'Mitsubishi', 'Xpander Cross',     2023, 355000000.00, 'Tersedia');

-- ========================================================
-- 4. TABEL transaksi
--    Relasi FK ke user dan kendaraan untuk Crystal Report
--    Kolom teks Pelanggan & Kendaraan tetap ada agar
--    aplikasi C# tidak perlu diubah semua
-- ========================================================

CREATE TABLE `transaksi` (
  `idtrans`    int(11)       NOT NULL AUTO_INCREMENT,
  `ID_user`    int(11)       NOT NULL,                 -- FK → user.ID_user
  `KendaraanID` int(11)      NOT NULL,                 -- FK → kendaraan.KendaraanID
  `Pelanggan`  varchar(100)  NOT NULL,                 -- redundant teks (untuk kompatibilitas app)
  `Kendaraan`  varchar(100)  NOT NULL,                 -- redundant teks (untuk kompatibilitas app)
  `Harga`      decimal(18,2) NOT NULL,
  `DP`         decimal(18,2) NOT NULL,
  `Sisa_kredit` decimal(18,2) NOT NULL,
  `Tanggal`    date          DEFAULT NULL,
  PRIMARY KEY (`idtrans`),
  KEY `fk_trans_user`     (`ID_user`),
  KEY `fk_trans_kendaraan` (`KendaraanID`),
  CONSTRAINT `fk_trans_user`
    FOREIGN KEY (`ID_user`)     REFERENCES `user`     (`ID_user`),
  CONSTRAINT `fk_trans_kendaraan`
    FOREIGN KEY (`KendaraanID`) REFERENCES `kendaraan` (`KendaraanID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `transaksi` (`idtrans`, `ID_user`, `KendaraanID`, `Pelanggan`, `Kendaraan`, `Harga`, `DP`, `Sisa_kredit`, `Tanggal`) VALUES
(1, 11, 2, 'Dede', 'Honda Vario 150', 25000000, 10000000, 15000000, '2026-09-01');

SET FOREIGN_KEY_CHECKS = 1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
