<html lang='en'>
    <head>
        <title>PHP Variables</title>
    </head>
    <body>
        <?php
            // Variable definition
            $user = "Angelo";
            $age = 25;
            // Variables can be inserted into strings
            echo "Hello $user";
        ?> <br />
        <?php
            // Or concatenated strings using full-stop (.)
            echo "10 years ago, you were: " . $age - 10 . "<br />";
            echo "In 20 years, you will be: " . $age + 20;
            // Variables can be inserted into text (which isnt seperated by spaces) like so:
            echo "<br />Supercalifragilistic{$user}expialidocious";
        ?>
    </body>
</html>