<?php
const PARAMS = ["HOST" => "localhost",
    "USER" => "root",
    "PASSWORD" => "",
    "DATABASE" => "gallery"];

$password_hash=password_hash('password', PASSWORD_BCRYPT);

$users=[
    "user1"=>['name1','password','something@gmail.com',$password_hash],
    "user2"=>['name2','password2','something2@gmail.com',$password_hash],
    "user3"=>['name3','password3','something3@gmail.com',$password_hash]];