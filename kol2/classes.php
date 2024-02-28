<?php
abstract class Gallery{
    public string $quality;
    public string $keywords;

    public function setQuality($quality)
    {
        return $this->quality=$quality;
    }

    public function setKeywords($keywords)
    {
        return $this->keywords=$keywords;
    }
    abstract protected function getInfo();
    abstract protected function setPhotographer();
}

class Image extends Gallery {
    public string $name;
    public string $title;
    public string $photographer;
    //public array $array;

    public function __construct(string $name,string $title,string $photographer)
    {
        $this->name=$name;
        $this->title=$title;
        $this->photographer=$photographer;
    }

    public function setKeywords($keywords)
    {
        return $this->keywords=$keywords;
    }

    public function getInfo()
    {
        return $array=array(
            $this->name=>$this->title,$this->photographer);
    }

    public function setPhotographer(): string
    {
        return 'randomName';
    }
}

$image1=new Image('pehely', 'macska', 'ya mom');
$image2=new Image('photoname', 'cat', 'me');
$photo=$image1->setPhotographer();
echo $photo.'<br>';
$keyword=$image1->setKeywords('macska');
echo $keyword.'<br>';

var_dump($image1->getInfo());
var_dump($image2->getInfo());

//this is what he wanted i assume or meant i dont know the exercise feels unfinished
//correction, WHAT?!