<?php
$cat = " n2a4t5u55re spo12r54t funn98y sea2! su#!mmer!";
$exploded=explode(' ', $cat);
function ArraySort($var):array
{
    $newArray=[];
    if (preg_match('/[A-Za-z]/', $var) && preg_match('/[0-9]/', $var) and strlen($var)>4) //use regex to find the word which contains numbers and letters and is longer than 4 characters
        {
            $newArray[] = $var; //slap it into an array
        }
    return $newArray; //return it
}
$catTemp = array_map("ArraySort", $exploded); //this good, we use array map to slap the exploded arrays items into the function
$categories[]=null;

foreach (array_filter($catTemp) as $item) //we go through array
{
    $outputString1 = preg_replace('/[^0-9]/', '', $item[0]); //use regex to remove numbers from arrayitem
    $outputString2 = substr($item[0],0);
    $words=preg_replace('/[0-9]+/', '', $outputString2); ////use regex to remove letters from arrayitem
    $categories[$int=(int)$outputString1]=$words; //convert the numbers to int
}
ksort($categories); //sort array with keys
var_dump($categories);//done