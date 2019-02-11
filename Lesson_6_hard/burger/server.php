




<?php

$name = $_POST['user-name']; // label + id ['user-name']
$phone - $_POST['phone-number'];
$street = $_POST['street'];
$house = $_POST['house'];
$building = $_POST['building'];
$appartment = $_POST['appartment'];
$floor = $_POST['floor'];
$area = $_POST['text-area'];
$change = $_POST['change'];
$card = $_POST['by-card'];


$disturb = $_POST['dont-disturb']; // 1 или null 
$disturb = isset($disturb) ? 'НЕТ' : 'ДА'; 

$money = $_POST['change'];
$money = isset($money) ? 'НЕТ' : 'ДА'; 

$credit = $_POST['by-card'];
$credit = isset($credit) ? 'НЕТ' : 'ДА'; 

$mail__message = "

Имя: . $name . 
Номер телефона: . $phone .
Улица:  . $street . 
Дом:  . $house . 
Корпус: . $building . 
Квартира:  . $appartment . 
Этаж:  . $floor . 
Форма:  . $area . 
Сдача:  .  $change .
Кредитная карта:  . $card . 
Перезванивать: .  $disturb . 

";


$mail = mail('dubstr1@gmail.com', 'order', $mail__message, $headers);

if ($mail) {
    $data['status'] = "OK";
    $data['mes'] = "Mail sent";
}else {
    $data['status'] = "NO";
    $data['mes'] = "Error";
}
header('Content-type:application/json;charset=utf-8');
echo json_encode ($data);
?>

