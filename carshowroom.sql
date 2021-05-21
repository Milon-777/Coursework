-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 21 2021 г., 19:21
-- Версия сервера: 10.3.22-MariaDB
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `carshowroom`
--

-- --------------------------------------------------------

--
-- Структура таблицы `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `type` varchar(50) CHARACTER SET utf8 NOT NULL,
  `price` int(11) NOT NULL,
  `fuelConsumption` int(11) NOT NULL,
  `power` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `cars`
--

INSERT INTO `cars` (`id`, `name`, `type`, `price`, `fuelConsumption`, `power`) VALUES
(1, 'Mercedes-Benz S-Class 500 9G-Tronic', 'Седан', 210000, 8, 435),
(2, 'Mercedes-Benz G-Class Mercedes-AMG G63 G-Ttonic', 'Позашляховик', 278436, 24, 585),
(3, 'Bentley Continental GT V8 4.0i AT', 'Купе', 361183, 12, 550),
(4, 'Subaru Outback 2.5i CVT Lineartronic', 'Універсал', 46175, 8, 175),
(5, 'Mercedes-Benz V-Class V 200d MT', 'Мінівен', 58942, 6, 136),
(6, 'Renault Sandero 0.9TCe 5РКП', 'Хетчбек', 13907, 6, 90),
(7, 'Mercedes-Benz Vito', 'Мініфургон', 32424, 7, 88),
(8, 'Bentley Continental GT 6.0 W12 TSI AT', 'Кабріолет', 379685, 13, 635),
(9, 'Mercedes-Benz S 600 TOP LUX', 'Лімузин', 15000, 13, 517),
(10, 'Ford Ranger Двойная 2.0D EcoBlue MT', 'Пікап', 37950, 7, 170);

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `loginUser` varchar(50) CHARACTER SET utf8 NOT NULL,
  `carName` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dateOrder` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `orders`
--

INSERT INTO `orders` (`id`, `loginUser`, `carName`, `dateOrder`) VALUES
(1, 'milon', 'Bentley Continental GT V8 4.0i AT', '2021-04-28 13:29:35'),
(2, 'milon', 'Renault Sandero 0.9TCe 5РКП', '2021-05-08 18:30:43'),
(3, 'milon', 'Subaru Outback 2.5i CVT Lineartronic', '2021-05-10 22:12:23');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `login` varchar(50) CHARACTER SET utf8 NOT NULL,
  `password` varchar(50) CHARACTER SET utf8 NOT NULL,
  `phoneNumber` varchar(10) CHARACTER SET utf8 NOT NULL,
  `mail` varchar(50) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`, `phoneNumber`, `mail`) VALUES
(1, 'milon', '12345', '0950654235', 'milon777.official@gmail.com');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nameUniq` (`name`);

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `carName` (`carName`),
  ADD KEY `orders_ibfk_1` (`loginUser`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `loginUniq` (`login`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`loginUser`) REFERENCES `users` (`login`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`carName`) REFERENCES `cars` (`name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
