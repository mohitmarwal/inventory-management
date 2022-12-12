-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2022 at 04:27 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventoryapp`
--
CREATE DATABASE IF NOT EXISTS `inventoryapp` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `inventoryapp`;

-- --------------------------------------------------------

--
-- Table structure for table `bags`
--

CREATE TABLE `bags` (
  `Type` varchar(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bags`
--

INSERT INTO `bags` (`Type`, `id`) VALUES
('Katta', 1),
('Bardana', 5),
('', 8),
('polythene', 9),
('paper', 10);

-- --------------------------------------------------------

--
-- Table structure for table `broker`
--

CREATE TABLE `broker` (
  `id` int(11) NOT NULL,
  `name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `broker`
--

INSERT INTO `broker` (`id`, `name`) VALUES
(1, 'Nirav');

-- --------------------------------------------------------

--
-- Table structure for table `ds`
--

CREATE TABLE `ds` (
  `Min` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `Rate` double NOT NULL,
  `Plant` varchar(11) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ds`
--

INSERT INTO `ds` (`Min`, `Max`, `Rate`, `Plant`, `ID`) VALUES
(2, 10, 0.48, 'Dainika', 2);

-- --------------------------------------------------------

--
-- Table structure for table `fm`
--

CREATE TABLE `fm` (
  `Min` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `Rate` int(11) NOT NULL,
  `Plant` varchar(11) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fm`
--

INSERT INTO `fm` (`Min`, `Max`, `Rate`, `Plant`, `ID`) VALUES
(0, 2, 0, 'Dainika', 2);

-- --------------------------------------------------------

--
-- Table structure for table `goods`
--

CREATE TABLE `goods` (
  `Name` varchar(256) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `goods`
--

INSERT INTO `goods` (`Name`, `Id`) VALUES
('Toor', 1),
('Soya', 2),
('Chana', 3),
('Turmeric', 6),
('Groundnut', 7),
('Rice', 10);

-- --------------------------------------------------------

--
-- Table structure for table `gs`
--

CREATE TABLE `gs` (
  `Min` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `Rate` int(11) NOT NULL,
  `Plant` varchar(256) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gs`
--

INSERT INTO `gs` (`Min`, `Max`, `Rate`, `Plant`, `ID`) VALUES
(0, 2, 0, 'Dainika', 2);

-- --------------------------------------------------------

--
-- Table structure for table `hamali`
--

CREATE TABLE `hamali` (
  `Plant` varchar(256) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL,
  `Bagtype` varchar(256) NOT NULL,
  `Rate` int(11) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hamali`
--

INSERT INTO `hamali` (`Plant`, `Bagtype`, `Rate`, `ID`) VALUES
('Dainika', 'Katta', 2, 1),
('Dainika', 'Bardana', 2, 3);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `Entry_no` int(11) NOT NULL,
  `Billno` int(11) NOT NULL,
  `PartnerName` varchar(100) NOT NULL,
  `MobileNumber` varchar(100) NOT NULL,
  `EmailId` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `DealerSign` varchar(100) NOT NULL,
  `ProcurerSign` varchar(100) NOT NULL,
  `Transportation` varchar(100) NOT NULL,
  `GoodType` varchar(100) NOT NULL,
  `PlantName` varchar(256) NOT NULL,
  `Quantity` varchar(100) NOT NULL,
  `BagType` varchar(100) NOT NULL,
  `NoBags` int(11) NOT NULL,
  `RatePerQuintal` varchar(100) NOT NULL,
  `Subtotal` varchar(100) NOT NULL,
  `TransactionCharges` varchar(100) NOT NULL,
  `QualityDeduction` varchar(100) NOT NULL,
  `FM` int(11) NOT NULL,
  `DM` int(11) NOT NULL,
  `MS` int(11) NOT NULL,
  `TotalAmount` varchar(100) NOT NULL,
  `PaymentMethod` varchar(100) NOT NULL,
  `PaymentStatus` varchar(256) NOT NULL,
  `HandOver` varchar(256) NOT NULL,
  `Remarks` varchar(256) NOT NULL,
  `Amount Pending` int(11) NOT NULL,
  `Quantity1` int(11) NOT NULL,
  `Rate1` int(11) NOT NULL,
  `Quantity2` int(11) NOT NULL,
  `Rate2` int(11) NOT NULL,
  `broker` varchar(256) NOT NULL,
  `BR1` int(11) NOT NULL,
  `BR2` int(11) NOT NULL,
  `BR3` int(11) NOT NULL,
  `BQ1` int(11) NOT NULL,
  `BQ2` int(11) NOT NULL,
  `BQ3` int(11) NOT NULL,
  `Tax` int(11) NOT NULL,
  `SS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`Entry_no`, `Billno`, `PartnerName`, `MobileNumber`, `EmailId`, `Date`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName`, `Quantity`, `BagType`, `NoBags`, `RatePerQuintal`, `Subtotal`, `TransactionCharges`, `QualityDeduction`, `FM`, `DM`, `MS`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`, `Amount Pending`, `Quantity1`, `Rate1`, `Quantity2`, `Rate2`, `broker`, `BR1`, `BR2`, `BR3`, `BQ1`, `BQ2`, `BQ3`, `Tax`, `SS`) VALUES
(7, 0, 'Pravin', '8983000588', 'mohit.marwal@gmail.com', '2022-41-16', 'mohit', 'mohit', 'mh12dk7688', 'Soya', 'Dainika', '56', 'Bardana', 4, '7', '80', '78', '0', 0, 0, 0, '39280780', 'TRF', 'Pending', 'done', 'COmpleted', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(9, 0, 'Pravin', '902106767', 'mohitxp@msn.com', '2022-36-16', 'shilpa', 'shilpa', 'mh14bc7866', 'Toor', 'Dainika', '4', 'Katta', 4, '4', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Complete', 'received', 'Tranaction Done', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(10, 0, 'mohit', '9021306767', 'mohitxp@msn.com', '2022-39-16', 'manan', 'manan', 'gj1bc9856', 'Toor', 'Dainika', '4', 'Katta', 4, '43', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Received', 'Done', 'Transaction complete', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(11, 0, 'mohit', '12345678', 'snika.rathi@gmail.com', '2022-44-16', 'pravin', 'pravin', 'mh12rt5678', 'Toor', 'Dainika', '3', 'Katta', 3, '3', '3', '3', '3', 0, 0, 0, '9333', 'NEFT', 'Received', 'pending', 'pending', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(12, 0, 'Pravin', '823707032252', 'sonika.rathi@msn.com', '09-01-2022', 'pravin', 'pravin', 'mh12dk7688', 'Soya', 'Mantra Organic', '3', 'Bardana', 3, '3', '3', '3', '3', 0, 0, 0, '9333', 'NEFT', 'Received', 'Done', 'Transaction Done', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(13, 0, 'Pravin', '898300588', 'mohit.marwal@gmail.com', '02-01-2022', 'mohit', 'mohit', 'mh12Dk7688', 'Soya', 'Fortune', '4', 'Bardana', 4, '4', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Received', 'Done', 'Transaction Done', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(14, 0, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '13-02-2022', 'mohit', 'mohit', 'mh12dk7688', 'Toor', 'Dainika', '2', 'Katta', 2, '34', '2', '2', '2', 2, 3, 4, '68222', 'NEFT', 'Recived', 'Done', 'transaction completed', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(15, 0, 'sonika', '9876445568', 'sonika.rathi@gmail.com', '13-02-2022', 'sonika', 'sonika', 'Mh12dk7688', 'Turmeric', 'Mantra Organic', '10', 'Bardana', 6, '45', '100', '200', '0', 67, 48, 24, '450100200500', 'NEFT', 'Received', 'Done', 'Transaction Done', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(16, 0, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '05-01-2022', 'mohit', 'mohit', 'mh12dk7688', 'Toor', 'Dainika', '5', 'Katta', 4, '4', '5', '5', '5', 5, 5, 5, '20555', 'NEFT', 'received', 'pending', 'tranasction done', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(17, 0, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-01-2022', 'mohit', 'mohit', 'dfssdf', 'Toor', 'Dainika', '4', 'Katta', 3, '2', '3', '5', '4', 3, 3, 3, '8354', 'NEFT', '8000', 'Pending', 'pending', 354, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(18, 12567, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-01-2022', 'mohit', 'mohit', 'mh-12rt6789', 'Toor', 'Dainika', '4', 'Katta', 3, '5', '3', '2', '5', 4, 5, 3, '20325', 'NEFT', 'Complete', '20325', 'Complete', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(19, 13576, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '07-01-2022', 'shilpa', 'shilpa', 'mh45-yu8769', 'Toor', 'Dainika', '12504', 'Katta', 4, '100', '1250400', '737.146', '1000', 3, 4, 2, '1248662.854', 'CASH', 'Pending', '1100000', 'complete', 48722, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(20, 13577, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '05-01-2022', 'mohit', 'mohit', '12567', 'Toor', 'Dainika', '4', 'Katta', 3, '3', '3', '4', '2', 2, 3, 0, '12342', 'NEFT', 'Pending', '1234', 'pending', 11108, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(21, 1234567, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '04-03-2022', '234', '234', '234', 'Toor', 'Dainika', '44367', 'Katta', 3, '100', '4436700', '2617.6471', '10', 12, 3, 3, '4434072.3529', 'CASH', 'Pending', '100', '234234234', 4433972, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(22, 12341545, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '04-03-2022', 'qwe', 'qwe', 'qweqweqwe', 'Toor', 'Dainika', '33', 'Katta', 2, '22', '726', '59', '100', 11, 22, 11, '567', 'NEFT', 'Pending', '111', 'adasd', 456, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(23, 123123, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-03-2022', '234', '234', '234234234', 'Toor', 'Dainika', '12', 'Katta', 12, '12', '144', '59', '11', 12, 12, 12, '74', 'NEFT', 'Pending', '11', 'swfwefewfe', 63, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(24, 12312, 'Pravin', '', '', '04-04-2022', '', '', '', 'Toor', 'Dainika', '23', 'Katta', 23, '23', '529.00', '59', '', 2, 12, 12, '', 'NEFT', 'Pending', '', '', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(25, 234, 'Pravin', '', '', '08-04-2022', '', '', '', 'Toor', 'Dainika', '', 'Katta', 0, '', '', '59', '', 0, 0, 0, '', 'NEFT', 'Pending', '', '', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(26, 123, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '01-04-2022', '', '', '', 'Toor', 'Dainika', '23', 'Katta', 0, '23', '529.00', '59', '', 0, 0, 0, '', 'NEFT', 'Pending', '', '', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(27, 1234, '', '', '', '02-04-2022', '', '', '', '', '', '', '', 0, '', '', '', '', 0, 0, 0, '', '', '', '', '', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(28, 1233, '', '', '', '12-06-2022', '', '', '', '', '', '', '', 0, '', '', '', '', 0, 0, 0, '', '', '', '', '', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, 0, 0),
(29, 446677, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '19-06-2022', 'qwe', 'qwe', 'qwe', 'Toor', 'Fortune', '12', 'Katta', 2, '12', '144.00', '1.11', '1212', 3, 23, 23, '1880.89', 'CASH', 'Pending', '324', '123123', 502, 12, 56, 34, 67, '', 0, 0, 0, 0, 0, 0, 0, 0),
(30, 502, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '13-06-2022', 'sdf', 'sdf', 'qweqw', 'Toor', 'Dainika', '416800', 'polythene', 3, '1', '1250400.00', '737.01', '1234', 23, 23, 23, '1248428.99', 'CASH', 'Pending', '123', '123', 1249538, 416800, 1, 416800, 1, '', 0, 0, 0, 0, 0, 0, 0, 0),
(31, 507, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '18-06-2022', 'sa', 'asd', 'das', 'Toor', 'Dainika', '10', 'Bardana', 2, '10', '150.00', '59', '', 3, 34, 34, '88.00', 'TRF', 'Pending', '23', '23', 23, 5, 5, 5, 5, '', 0, 0, 0, 0, 0, 0, 0, 0),
(32, 890, 'sonika', '9876445568', 'sonika.rathi@gmail.com', '12-06-2022', '23', '234', '32', 'Toor', 'Dainika', '234', 'Katta', 32, '234', '164268.00', '96.78', '', 234, 234, 324, '', 'CASH', 'Pending', '3434', '32werewr', 160503, 234, 234, 234, 234, 'Nirav', 0, 0, 0, 0, 0, 0, 0, 0),
(33, 556, 'ashneer grover', '7878789045', 'ashneer.grover@gmail.com', '18-06-2022', 'qad', 'qw', 'qwe', 'Toor', 'Dainika', '23', 'Katta', 2, '23', '1587.00', '0.92', '', 23, 23, 2323, '1563.08', 'CASH', 'Pending', '123', '123', 1440, 23, 23, 23, 23, 'Nirav', 0, 0, 0, 0, 0, 0, 0, 0),
(34, 122323, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '18-06-2022', 'awd', 'qwe', 'qwe', 'Toor', 'Dainika', '213', 'Bardana', 23, '23', '5957.00', '', 'System.Windows.Controls.TextBox: 23233', 213, 123, 123, '232323', 'CASH', 'Complete', '2332', '2323123', 12, 23, 23, 23, 23, 'Nirav', 0, 0, 0, 0, 0, 0, 0, 0),
(35, 1122, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '25-06-2022', 'AS', 'as', 'ASas', 'Soya', 'Dainika', '12', 'Katta', 1, '12', '432.00', '59', '1222', 23, 32, 33, '-849.00', 'NEFT', 'Pending', '12', '12', -861, 12, 12, 12, 12, 'Nirav', 0, 0, 0, 0, 0, 0, 0, 0),
(36, 2345, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '26-06-2022', '12', '12', '123123', 'Soya', 'Dainika', '12', 'Katta', 12, '12', '432.00', '59', '12', 14, 14, 14, '361.00', 'RTGS', '', '112', 'qweqwe', 249, 12, 12, 12, 12, 'Nirav', 0, 0, 0, 0, 0, 0, 0, 0),
(37, 123456, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '04-06-2022', '12', '12', '12312', 'Soya', 'Dainika', '15', 'Katta', 12, '15', '225.00', '', '', 15, 16, 17, '', '', '', '', '', 0, 0, 0, 0, 0, 'Nirav', 0, 0, 0, 0, 0, 0, 0, 0),
(38, 778899, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '20-08-2022', 'esdf', 'sdf', 'sdf', 'Toor', 'Tata Sampan', '2', 'Katta', 3, '12', '192.00', '59', '12', 2, 2, 2, '21', 'RTGS', 'Pending', '12', '21', 9, 12, 2, 12, 12, 'Nirav', 2, 2, 2, 2, 2, 2, 0, 0),
(39, 556699, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '13-08-2022', 'ssad', 'asd', 'asd', 'Soya', 'Fortune', '12', 'Katta', 12, '12', '300.00', '59', '12', 12, 12, 12, '229.00', 'NEFT', 'Pending', '12', '12', 212, 12, 12, 12, 1, 'Nirav', 12, 12, 1, 1, 0, 78, 0, 34);

-- --------------------------------------------------------

--
-- Table structure for table `ms`
--

CREATE TABLE `ms` (
  `Min` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `Rate` double NOT NULL,
  `Plant` varchar(11) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ms`
--

INSERT INTO `ms` (`Min`, `Max`, `Rate`, `Plant`, `ID`) VALUES
(10, 12, 0.4, 'Dainika', 2);

-- --------------------------------------------------------

--
-- Table structure for table `partner`
--

CREATE TABLE `partner` (
  `Name` varchar(256) NOT NULL,
  `Email` varchar(256) NOT NULL,
  `Id` int(30) NOT NULL,
  `Phone` bigint(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `partner`
--

INSERT INTO `partner` (`Name`, `Email`, `Id`, `Phone`) VALUES
('Pravin', 'pravin.reddy@gmail.com', 1, 9865445689),
('mohit', 'mohit.marwal@gmail.com', 2, 8983000588),
('sonika', 'sonika.rathi@gmail.com', 3, 9876445568),
('ashneer grover', 'ashneer.grover@gmail.com', 4, 7878789045),
('parth', 'parth.marwal@gmail.com', 6, 9876445934),
('parth', 'parth.marwal@gmail.com', 7, 8983000588);

-- --------------------------------------------------------

--
-- Table structure for table `password`
--

CREATE TABLE `password` (
  `Number` int(11) NOT NULL,
  `Password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `password`
--

INSERT INTO `password` (`Number`, `Password`) VALUES
(1, 'Sonika');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Method` varchar(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`Method`, `id`) VALUES
('NEFT', 1),
('RTGS', 2),
('TRF', 3),
('CASH', 4);

-- --------------------------------------------------------

--
-- Table structure for table `plant`
--

CREATE TABLE `plant` (
  `Name` varchar(256) NOT NULL,
  `id` int(11) NOT NULL,
  `Backcomm` int(11) NOT NULL,
  `Rate` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plant`
--

INSERT INTO `plant` (`Name`, `id`, `Backcomm`, `Rate`) VALUES
('Dainika', 1, 0, '0'),
('Fortune', 2, 0, '0'),
('Tata Sampan', 3, 0, '0'),
('Mantra Organic', 4, 0, '0'),
('HindustanLiver', 5, 0, '0'),
('Ashirwad', 6, 0, '0');

-- --------------------------------------------------------

--
-- Table structure for table `quantity`
--

CREATE TABLE `quantity` (
  `Type` varchar(256) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `quantity`
--

INSERT INTO `quantity` (`Type`, `Id`) VALUES
('Quintal', 1),
('Tonnes', 2);

-- --------------------------------------------------------

--
-- Table structure for table `ss`
--

CREATE TABLE `ss` (
  `Min` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `Rate` int(11) NOT NULL,
  `Plant` varchar(256) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ss`
--

INSERT INTO `ss` (`Min`, `Max`, `Rate`, `Plant`, `ID`) VALUES
(0, 2, 0, 'Dainika', 4);

-- --------------------------------------------------------

--
-- Table structure for table `transport`
--

CREATE TABLE `transport` (
  `TruckNo` varchar(11) NOT NULL,
  `DriverName` varchar(11) NOT NULL,
  `PhoneNum` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bags`
--
ALTER TABLE `bags`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `broker`
--
ALTER TABLE `broker`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ds`
--
ALTER TABLE `ds`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `fm`
--
ALTER TABLE `fm`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `goods`
--
ALTER TABLE `goods`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `gs`
--
ALTER TABLE `gs`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `hamali`
--
ALTER TABLE `hamali`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`Entry_no`);

--
-- Indexes for table `ms`
--
ALTER TABLE `ms`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `password`
--
ALTER TABLE `password`
  ADD PRIMARY KEY (`Number`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `plant`
--
ALTER TABLE `plant`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `quantity`
--
ALTER TABLE `quantity`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `ss`
--
ALTER TABLE `ss`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `transport`
--
ALTER TABLE `transport`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bags`
--
ALTER TABLE `bags`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `broker`
--
ALTER TABLE `broker`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `ds`
--
ALTER TABLE `ds`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `fm`
--
ALTER TABLE `fm`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `goods`
--
ALTER TABLE `goods`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `gs`
--
ALTER TABLE `gs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `hamali`
--
ALTER TABLE `hamali`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `Entry_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `ms`
--
ALTER TABLE `ms`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `partner`
--
ALTER TABLE `partner`
  MODIFY `Id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `password`
--
ALTER TABLE `password`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `plant`
--
ALTER TABLE `plant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `quantity`
--
ALTER TABLE `quantity`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `ss`
--
ALTER TABLE `ss`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transport`
--
ALTER TABLE `transport`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Database: `phpmyadmin`
--
CREATE DATABASE IF NOT EXISTS `phpmyadmin` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `phpmyadmin`;

-- --------------------------------------------------------

--
-- Table structure for table `pma__bookmark`
--

CREATE TABLE `pma__bookmark` (
  `id` int(10) UNSIGNED NOT NULL,
  `dbase` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `user` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `label` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `query` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Bookmarks';

-- --------------------------------------------------------

--
-- Table structure for table `pma__central_columns`
--

CREATE TABLE `pma__central_columns` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_length` text COLLATE utf8_bin DEFAULT NULL,
  `col_collation` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_isNull` tinyint(1) NOT NULL,
  `col_extra` varchar(255) COLLATE utf8_bin DEFAULT '',
  `col_default` text COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Central list of columns';

-- --------------------------------------------------------

--
-- Table structure for table `pma__column_info`
--

CREATE TABLE `pma__column_info` (
  `id` int(5) UNSIGNED NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `column_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `comment` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `mimetype` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Column information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__designer_settings`
--

CREATE TABLE `pma__designer_settings` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `settings_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Settings related to Designer';

-- --------------------------------------------------------

--
-- Table structure for table `pma__export_templates`
--

CREATE TABLE `pma__export_templates` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `export_type` varchar(10) COLLATE utf8_bin NOT NULL,
  `template_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `template_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved export templates';

-- --------------------------------------------------------

--
-- Table structure for table `pma__favorite`
--

CREATE TABLE `pma__favorite` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Favorite tables';

-- --------------------------------------------------------

--
-- Table structure for table `pma__history`
--

CREATE TABLE `pma__history` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `timevalue` timestamp NOT NULL DEFAULT current_timestamp(),
  `sqlquery` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='SQL history for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__navigationhiding`
--

CREATE TABLE `pma__navigationhiding` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Hidden items of navigation tree';

-- --------------------------------------------------------

--
-- Table structure for table `pma__pdf_pages`
--

CREATE TABLE `pma__pdf_pages` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `page_nr` int(10) UNSIGNED NOT NULL,
  `page_descr` varchar(50) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='PDF relation pages for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__recent`
--

CREATE TABLE `pma__recent` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Recently accessed tables';

--
-- Dumping data for table `pma__recent`
--

INSERT INTO `pma__recent` (`username`, `tables`) VALUES
('root', '[{\"db\":\"inventoryapp\",\"table\":\"ms\"},{\"db\":\"inventoryapp\",\"table\":\"ds\"},{\"db\":\"inventoryapp\",\"table\":\"ss\"},{\"db\":\"inventoryapp\",\"table\":\"gs\"},{\"db\":\"inventoryapp\",\"table\":\"fm\"},{\"db\":\"inventoryapp\",\"table\":\"plant\"},{\"db\":\"inventoryapp\",\"table\":\"hamali\"},{\"db\":\"inventoryapp\",\"table\":\"bags\"},{\"db\":\"inventoryapp\",\"table\":\"partner\"},{\"db\":\"inventoryapp\",\"table\":\"inventory\"}]');

-- --------------------------------------------------------

--
-- Table structure for table `pma__relation`
--

CREATE TABLE `pma__relation` (
  `master_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Relation table';

-- --------------------------------------------------------

--
-- Table structure for table `pma__savedsearches`
--

CREATE TABLE `pma__savedsearches` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved searches';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_coords`
--

CREATE TABLE `pma__table_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `pdf_page_number` int(11) NOT NULL DEFAULT 0,
  `x` float UNSIGNED NOT NULL DEFAULT 0,
  `y` float UNSIGNED NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for phpMyAdmin PDF output';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_info`
--

CREATE TABLE `pma__table_info` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `display_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__table_uiprefs`
--

CREATE TABLE `pma__table_uiprefs` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `prefs` text COLLATE utf8_bin NOT NULL,
  `last_update` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Tables'' UI preferences';

--
-- Dumping data for table `pma__table_uiprefs`
--

INSERT INTO `pma__table_uiprefs` (`username`, `db_name`, `table_name`, `prefs`, `last_update`) VALUES
('root', 'inventoryapp', 'inventory', '[]', '2022-06-14 10:45:55'),
('root', 'test', 'inventory', '{\"CREATE_TIME\":\"2022-01-16 18:46:43\",\"sorted_col\":\"`Entry_no`  DESC\"}', '2022-02-19 12:27:57'),
('root', 'test', 'partner', '{\"CREATE_TIME\":\"2022-01-16 11:04:21\"}', '2022-01-16 07:57:03');

-- --------------------------------------------------------

--
-- Table structure for table `pma__tracking`
--

CREATE TABLE `pma__tracking` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `version` int(10) UNSIGNED NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL,
  `schema_snapshot` text COLLATE utf8_bin NOT NULL,
  `schema_sql` text COLLATE utf8_bin DEFAULT NULL,
  `data_sql` longtext COLLATE utf8_bin DEFAULT NULL,
  `tracking` set('UPDATE','REPLACE','INSERT','DELETE','TRUNCATE','CREATE DATABASE','ALTER DATABASE','DROP DATABASE','CREATE TABLE','ALTER TABLE','RENAME TABLE','DROP TABLE','CREATE INDEX','DROP INDEX','CREATE VIEW','ALTER VIEW','DROP VIEW') COLLATE utf8_bin DEFAULT NULL,
  `tracking_active` int(1) UNSIGNED NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Database changes tracking for phpMyAdmin';

-- --------------------------------------------------------

--
-- Table structure for table `pma__userconfig`
--

CREATE TABLE `pma__userconfig` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `timevalue` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `config_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User preferences storage for phpMyAdmin';

--
-- Dumping data for table `pma__userconfig`
--

INSERT INTO `pma__userconfig` (`username`, `timevalue`, `config_data`) VALUES
('root', '2022-09-11 15:37:44', '{\"Console\\/Mode\":\"show\",\"NavigationWidth\":0}');

-- --------------------------------------------------------

--
-- Table structure for table `pma__usergroups`
--

CREATE TABLE `pma__usergroups` (
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL,
  `tab` varchar(64) COLLATE utf8_bin NOT NULL,
  `allowed` enum('Y','N') COLLATE utf8_bin NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User groups with configured menu items';

-- --------------------------------------------------------

--
-- Table structure for table `pma__users`
--

CREATE TABLE `pma__users` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Users and their assignments to user groups';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pma__central_columns`
--
ALTER TABLE `pma__central_columns`
  ADD PRIMARY KEY (`db_name`,`col_name`);

--
-- Indexes for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `db_name` (`db_name`,`table_name`,`column_name`);

--
-- Indexes for table `pma__designer_settings`
--
ALTER TABLE `pma__designer_settings`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_user_type_template` (`username`,`export_type`,`template_name`);

--
-- Indexes for table `pma__favorite`
--
ALTER TABLE `pma__favorite`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__history`
--
ALTER TABLE `pma__history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`,`db`,`table`,`timevalue`);

--
-- Indexes for table `pma__navigationhiding`
--
ALTER TABLE `pma__navigationhiding`
  ADD PRIMARY KEY (`username`,`item_name`,`item_type`,`db_name`,`table_name`);

--
-- Indexes for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  ADD PRIMARY KEY (`page_nr`),
  ADD KEY `db_name` (`db_name`);

--
-- Indexes for table `pma__recent`
--
ALTER TABLE `pma__recent`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__relation`
--
ALTER TABLE `pma__relation`
  ADD PRIMARY KEY (`master_db`,`master_table`,`master_field`),
  ADD KEY `foreign_field` (`foreign_db`,`foreign_table`);

--
-- Indexes for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_savedsearches_username_dbname` (`username`,`db_name`,`search_name`);

--
-- Indexes for table `pma__table_coords`
--
ALTER TABLE `pma__table_coords`
  ADD PRIMARY KEY (`db_name`,`table_name`,`pdf_page_number`);

--
-- Indexes for table `pma__table_info`
--
ALTER TABLE `pma__table_info`
  ADD PRIMARY KEY (`db_name`,`table_name`);

--
-- Indexes for table `pma__table_uiprefs`
--
ALTER TABLE `pma__table_uiprefs`
  ADD PRIMARY KEY (`username`,`db_name`,`table_name`);

--
-- Indexes for table `pma__tracking`
--
ALTER TABLE `pma__tracking`
  ADD PRIMARY KEY (`db_name`,`table_name`,`version`);

--
-- Indexes for table `pma__userconfig`
--
ALTER TABLE `pma__userconfig`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__usergroups`
--
ALTER TABLE `pma__usergroups`
  ADD PRIMARY KEY (`usergroup`,`tab`,`allowed`);

--
-- Indexes for table `pma__users`
--
ALTER TABLE `pma__users`
  ADD PRIMARY KEY (`username`,`usergroup`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__history`
--
ALTER TABLE `pma__history`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  MODIFY `page_nr` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Database: `test`
--
CREATE DATABASE IF NOT EXISTS `test` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `test`;

-- --------------------------------------------------------

--
-- Table structure for table `bags`
--

CREATE TABLE `bags` (
  `Type` varchar(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bags`
--

INSERT INTO `bags` (`Type`, `id`) VALUES
('Katta', 1),
('Bardana', 5),
('', 8),
('polythene', 9);

-- --------------------------------------------------------

--
-- Table structure for table `goods`
--

CREATE TABLE `goods` (
  `Name` varchar(256) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `goods`
--

INSERT INTO `goods` (`Name`, `Id`) VALUES
('Toor', 1),
('Soya', 2),
('Chana', 3),
('Turmeric', 6),
('Groundnut', 7),
('Rice', 10);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `Entry_no` int(11) NOT NULL,
  `Billno` int(11) NOT NULL,
  `PartnerName` varchar(100) NOT NULL,
  `MobileNumber` varchar(100) NOT NULL,
  `EmailId` varchar(100) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `DealerSign` varchar(100) NOT NULL,
  `ProcurerSign` varchar(100) NOT NULL,
  `Transportation` varchar(100) NOT NULL,
  `GoodType` varchar(100) NOT NULL,
  `PlantName` varchar(256) NOT NULL,
  `Quantity` varchar(100) NOT NULL,
  `BagType` varchar(100) NOT NULL,
  `NoBags` int(11) NOT NULL,
  `RatePerQuintal` varchar(100) NOT NULL,
  `Subtotal` varchar(100) NOT NULL,
  `TransactionCharges` varchar(100) NOT NULL,
  `QualityDeduction` varchar(100) NOT NULL,
  `FM` int(11) NOT NULL,
  `DM` int(11) NOT NULL,
  `MS` int(11) NOT NULL,
  `TotalAmount` varchar(100) NOT NULL,
  `PaymentMethod` varchar(100) NOT NULL,
  `PaymentStatus` varchar(256) NOT NULL,
  `HandOver` varchar(256) NOT NULL,
  `Remarks` varchar(256) NOT NULL,
  `Amount Pending` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`Entry_no`, `Billno`, `PartnerName`, `MobileNumber`, `EmailId`, `Date`, `DealerSign`, `ProcurerSign`, `Transportation`, `GoodType`, `PlantName`, `Quantity`, `BagType`, `NoBags`, `RatePerQuintal`, `Subtotal`, `TransactionCharges`, `QualityDeduction`, `FM`, `DM`, `MS`, `TotalAmount`, `PaymentMethod`, `PaymentStatus`, `HandOver`, `Remarks`, `Amount Pending`) VALUES
(7, 0, 'Pravin', '8983000588', 'mohit.marwal@gmail.com', '2022-41-16', 'mohit', 'mohit', 'mh12dk7688', 'Soya', 'Dainika', '56', 'Bardana', 4, '7', '80', '78', '0', 0, 0, 0, '39280780', 'TRF', 'Pending', 'done', 'COmpleted', 0),
(9, 0, 'Pravin', '902106767', 'mohitxp@msn.com', '2022-36-16', 'shilpa', 'shilpa', 'mh14bc7866', 'Toor', 'Dainika', '4', 'Katta', 4, '4', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Complete', 'received', 'Tranaction Done', 0),
(10, 0, 'mohit', '9021306767', 'mohitxp@msn.com', '2022-39-16', 'manan', 'manan', 'gj1bc9856', 'Toor', 'Dainika', '4', 'Katta', 4, '43', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Received', 'Done', 'Transaction complete', 0),
(11, 0, 'mohit', '12345678', 'snika.rathi@gmail.com', '2022-44-16', 'pravin', 'pravin', 'mh12rt5678', 'Toor', 'Dainika', '3', 'Katta', 3, '3', '3', '3', '3', 0, 0, 0, '9333', 'NEFT', 'Received', 'pending', 'pending', 0),
(12, 0, 'Pravin', '823707032252', 'sonika.rathi@msn.com', '09-01-2022', 'pravin', 'pravin', 'mh12dk7688', 'Soya', 'Mantra Organic', '3', 'Bardana', 3, '3', '3', '3', '3', 0, 0, 0, '9333', 'NEFT', 'Received', 'Done', 'Transaction Done', 0),
(13, 0, 'Pravin', '898300588', 'mohit.marwal@gmail.com', '02-01-2022', 'mohit', 'mohit', 'mh12Dk7688', 'Soya', 'Fortune', '4', 'Bardana', 4, '4', '4', '4', '4', 0, 0, 0, '16444', 'NEFT', 'Received', 'Done', 'Transaction Done', 0),
(14, 0, 'mohit', '8983000588', 'mohit.marwal@gmail.com', '13-02-2022', 'mohit', 'mohit', 'mh12dk7688', 'Toor', 'Dainika', '2', 'Katta', 2, '34', '2', '2', '2', 2, 3, 4, '68222', 'NEFT', 'Recived', 'Done', 'transaction completed', 0),
(15, 0, 'sonika', '9876445568', 'sonika.rathi@gmail.com', '13-02-2022', 'sonika', 'sonika', 'Mh12dk7688', 'Turmeric', 'Mantra Organic', '10', 'Bardana', 6, '45', '100', '200', '0', 67, 48, 24, '450100200500', 'NEFT', 'Received', 'Done', 'Transaction Done', 0),
(16, 0, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '05-01-2022', 'mohit', 'mohit', 'mh12dk7688', 'Toor', 'Dainika', '5', 'Katta', 4, '4', '5', '5', '5', 5, 5, 5, '20555', 'NEFT', 'received', 'pending', 'tranasction done', 0),
(17, 0, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-01-2022', 'mohit', 'mohit', 'dfssdf', 'Toor', 'Dainika', '4', 'Katta', 3, '2', '3', '5', '4', 3, 3, 3, '8354', 'NEFT', '8000', 'Pending', 'pending', 354),
(18, 12567, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '06-01-2022', 'mohit', 'mohit', 'mh-12rt6789', 'Toor', 'Dainika', '4', 'Katta', 3, '5', '3', '2', '5', 4, 5, 3, '20325', 'NEFT', 'Complete', '20325', 'Complete', 0),
(19, 13576, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '07-01-2022', 'shilpa', 'shilpa', 'mh45-yu8769', 'Toor', 'Dainika', '12504', 'Katta', 4, '100', '1250400', '737.146', '1000', 3, 4, 2, '1248662.854', 'CASH', 'Pending', '1100000', 'complete', 48722),
(20, 13577, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '05-01-2022', 'mohit', 'mohit', '12567', 'Toor', 'Dainika', '4', 'Katta', 3, '3', '3', '4', '2', 2, 3, 0, '12342', 'NEFT', 'Pending', '1234', 'pending', 11108),
(21, 1234567, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '04-03-2022', '234', '234', '234', 'Toor', 'Dainika', '44367', 'Katta', 3, '100', '4436700', '2617.6471', '10', 12, 3, 3, '4434072.3529', 'CASH', 'Pending', '100', '234234234', 4433972),
(22, 12341545, 'Pravin', '9865445689', 'pravin.reddy@gmail.com', '04-03-2022', 'qwe', 'qwe', 'qweqweqwe', 'Toor', 'Dainika', '33', 'Katta', 2, '22', '726', '59', '100', 11, 22, 11, '567', 'NEFT', 'Pending', '111', 'adasd', 456);

-- --------------------------------------------------------

--
-- Table structure for table `partner`
--

CREATE TABLE `partner` (
  `Name` varchar(256) NOT NULL,
  `Email` varchar(256) NOT NULL,
  `Id` int(30) NOT NULL,
  `Phone` bigint(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `partner`
--

INSERT INTO `partner` (`Name`, `Email`, `Id`, `Phone`) VALUES
('Pravin', 'pravin.reddy@gmail.com', 1, 9865445689),
('mohit', 'mohit.marwal@gmail.com', 2, 8983000588),
('sonika', 'sonika.rathi@gmail.com', 3, 9876445568),
('ashneer grover', 'ashneer.grover@gmail.com', 4, 7878789045),
('parth', 'parth.marwal@gmail.com', 6, 9876445934);

-- --------------------------------------------------------

--
-- Table structure for table `password`
--

CREATE TABLE `password` (
  `Number` int(11) NOT NULL,
  `Password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `password`
--

INSERT INTO `password` (`Number`, `Password`) VALUES
(1, 'Pravin');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `Method` varchar(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`Method`, `id`) VALUES
('NEFT', 1),
('RTGS', 2),
('TRF', 3),
('CASH', 4);

-- --------------------------------------------------------

--
-- Table structure for table `plant`
--

CREATE TABLE `plant` (
  `Name` varchar(256) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plant`
--

INSERT INTO `plant` (`Name`, `id`) VALUES
('Dainika', 1),
('Fortune', 2),
('Tata Sampan', 3),
('Mantra Organic', 4),
('HindustanLiver', 5),
('Ashirwad', 6);

-- --------------------------------------------------------

--
-- Table structure for table `quantity`
--

CREATE TABLE `quantity` (
  `Type` varchar(256) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `quantity`
--

INSERT INTO `quantity` (`Type`, `Id`) VALUES
('Quintal', 1),
('Tonnes', 2);

-- --------------------------------------------------------

--
-- Table structure for table `transport`
--

CREATE TABLE `transport` (
  `TruckNo` varchar(11) NOT NULL,
  `DriverName` varchar(11) NOT NULL,
  `PhoneNum` int(11) NOT NULL,
  `Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bags`
--
ALTER TABLE `bags`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `goods`
--
ALTER TABLE `goods`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`Entry_no`);

--
-- Indexes for table `partner`
--
ALTER TABLE `partner`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `password`
--
ALTER TABLE `password`
  ADD PRIMARY KEY (`Number`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `plant`
--
ALTER TABLE `plant`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `quantity`
--
ALTER TABLE `quantity`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `transport`
--
ALTER TABLE `transport`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bags`
--
ALTER TABLE `bags`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `goods`
--
ALTER TABLE `goods`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `Entry_no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `partner`
--
ALTER TABLE `partner`
  MODIFY `Id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `password`
--
ALTER TABLE `password`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `plant`
--
ALTER TABLE `plant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `quantity`
--
ALTER TABLE `quantity`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transport`
--
ALTER TABLE `transport`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
