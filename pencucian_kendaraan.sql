-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2021 at 10:17 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pencucian_kendaraan`
--

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `idkaryawan` int(15) NOT NULL,
  `nama_karyawan` varchar(50) NOT NULL,
  `no_hp` varchar(15) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `level` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`idkaryawan`, `nama_karyawan`, `no_hp`, `alamat`, `level`) VALUES
(1, 'Tri wahyuni', '085621125132', 'Anjir', 'Kasir'),
(2, 'Muhammad', '085652422123', 'Sampit', 'Pekerja'),
(3, 'Nasrudin', '085822455849', 'Jalan AMD', 'Pekerja'),
(4, 'Rizky Ahmad', '087621414212', 'Jl. Handil Bakti', 'Pekerja'),
(5, 'Trisena', '09898977', 'Bjb', 'Kasir');

-- --------------------------------------------------------

--
-- Table structure for table `paket`
--

CREATE TABLE `paket` (
  `idpaket` int(15) NOT NULL,
  `kategori` varchar(50) NOT NULL,
  `mobil` int(50) NOT NULL,
  `motor` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `paket`
--

INSERT INTO `paket` (`idpaket`, `kategori`, `mobil`, `motor`) VALUES
(7, 'Manual', 50000, 15000),
(10, 'Waterless', 80000, 25000),
(11, 'Touchless', 60000, 18000),
(12, 'Robotic', 90000, 30000);

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `idpelanggan` int(99) NOT NULL,
  `kode_pelanggan` char(30) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `jenis_kendaraan` varchar(15) NOT NULL,
  `merk_kendaraan` varchar(35) NOT NULL,
  `paket_pencucian` varchar(50) NOT NULL,
  `harga` int(50) NOT NULL,
  `no_hp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `pembayaran`
--

CREATE TABLE `pembayaran` (
  `idPembayaran` int(99) NOT NULL,
  `kode_pelanggan` char(30) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `jenis_kendaraan` varchar(15) NOT NULL,
  `merk_kendaraan` varchar(35) NOT NULL,
  `paket_pencucian` varchar(50) NOT NULL,
  `harga` int(50) NOT NULL,
  `no_hp` varchar(15) NOT NULL,
  `tgl_pembayaran` date DEFAULT NULL,
  `jam_pembayaran` time DEFAULT NULL,
  `nama_kasir` varchar(35) NOT NULL,
  `dibayar` int(25) NOT NULL,
  `kembalian` int(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pembayaran`
--

INSERT INTO `pembayaran` (`idPembayaran`, `kode_pelanggan`, `nama_pelanggan`, `jenis_kendaraan`, `merk_kendaraan`, `paket_pencucian`, `harga`, `no_hp`, `tgl_pembayaran`, `jam_pembayaran`, `nama_kasir`, `dibayar`, `kembalian`) VALUES
(31, 'P-010', 'Hasan', 'Motor', 'NMAX', 'Waterless', 25000, '0989123145658', '2021-11-24', '11:15:56', 'Muhammad Nasrudin', 100000, 75000),
(33, 'P-012', 'Tri', 'Mobil', 'Fortuner', 'Touchless', 60000, '098756724563', '2021-11-24', '11:25:05', 'Muhammad Nasrudin', 100000, 40000),
(34, 'P-013', 'Mujahid', 'Mobil', 'Alphard', 'Touchless', 60000, '087645678797', '2021-11-24', '11:42:35', 'Muhammad Nasrudin', 100000, 40000),
(35, 'P-014', 'Akhmad', 'Mobil', 'Lamborghini', 'Robotic', 90000, '098761211212', '2021-11-24', '11:44:57', 'Muhammad Nasrudin', 100000, 10000),
(36, 'P-015', 'Ade', 'Mobil', 'HR-V', 'Touchless', 60000, '0987124124', '2021-11-24', '12:04:09', 'Muhammad Nasrudin', 80000, 20000),
(39, 'P-006', 'Ahmad', 'Motor', 'Supra', 'Waterless', 25000, '089855338768', '2021-11-24', '10:57:20', 'Muhammad Nasrudin', 30000, 5000),
(40, 'P-001', 'Algi', 'Motor', 'Scoopy', 'Waterless', 25000, '086521231987', '2021-11-25', '08:05:15', 'Muhammad Nasrudin', 50000, 25000),
(41, 'P-002', 'Widhi', 'Mobil', 'Innova', 'Touchless', 60000, '098415678192', '2021-11-25', '08:11:20', 'Muhammad Nasrudin', 100000, 40000),
(42, 'P-003', 'Ahmad', 'Motor', 'Shogun', 'Manual', 15000, '086521231232', '2021-11-25', '08:12:46', 'Muhammad Nasrudin', 20000, 5000),
(43, 'P-004', 'Yogi', 'Mobil', 'Civic', 'Robotic', 90000, '085411118778', '0000-00-00', '01:20:27', 'Muhammad Nasrudin', 100000, 10000),
(44, 'P-005', 'Winanto', 'Motor', 'Beat Sreet', 'Waterless', 25000, '086512328765', '0000-00-00', '01:23:58', 'Muhammad Nasrudin', 50000, 25000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userid` int(15) NOT NULL,
  `username` varchar(50) NOT NULL,
  `userpassword` varchar(35) NOT NULL,
  `pengguna` varchar(50) DEFAULT NULL,
  `userlevel` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userid`, `username`, `userpassword`, `pengguna`, `userlevel`) VALUES
(1, 'nasrudin', 'nasrudin', 'Muhammad Nasrudin', 'admin'),
(2, 'pimpinan', 'pimpinan', 'nasrudin', 'pimpinan'),
(3, 'resti', 'resti', 'Resti Nur Amalia', 'kasir');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`idkaryawan`);

--
-- Indexes for table `paket`
--
ALTER TABLE `paket`
  ADD PRIMARY KEY (`idpaket`);

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`idpelanggan`);

--
-- Indexes for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD PRIMARY KEY (`idPembayaran`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `paket`
--
ALTER TABLE `paket`
  MODIFY `idpaket` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `pelanggan`
--
ALTER TABLE `pelanggan`
  MODIFY `idpelanggan` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `pembayaran`
--
ALTER TABLE `pembayaran`
  MODIFY `idPembayaran` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userid` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
