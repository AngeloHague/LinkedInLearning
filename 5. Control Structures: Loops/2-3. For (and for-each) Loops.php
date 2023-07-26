<html lang='en'>
    <head>
        <title>PHP For Loops</title>
    </head>
    <body>
        <?php
            // typical for loop
            for ($i = 1; $i <= 10; $i++) {
                echo $i;
            }
        ?>
        <br/>
        <?php
            // array
            $array = ['The', 'quick', 'brown', 'fox', ':)'];
            //for each loop
            foreach ($array as $word) {
                echo "{$word} ";
            }
        ?>
        <br/>
        <?php
            // associative arrays
            $person = array(
                "first_name" => "Angelo",
                "last_name" => "Hague",
                "address" => "123 Main Street",
                "city" => "Whoville",
                "state" => "Whereland",
                "post_code" => "WH3 R3"
            );
            //for each loop
            foreach ($person as $attribute => $data) {
                echo "{$attribute}: {$data} <br/>";
            }
        ?>
    </body>
</html>