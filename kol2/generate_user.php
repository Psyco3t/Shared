<?php
require_once 'config.php';
require_once 'db_config.php';

foreach ($users as $item)
{
    $password=$item[0].'-'.rand(150,900).'-'.date('m');
    $password_hash=password_hash($password, PASSWORD_BCRYPT);
    $sql="INSERT INTO `user` (`username`,`password`,`email`)
    VALUES ('$item[0]','$password_hash','$item[2]')";
    mysqli_query(databaseConnect(), $sql);
}

