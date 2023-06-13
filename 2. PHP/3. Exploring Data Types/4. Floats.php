<html lang='en'>
    <head>
        <title>PHP Floating Point Numbers</title>
    </head>
    <body>
        <h3>Math Function</h3>
        Float: <?php echo $float = 3.14; ?><br />
        +: <?php echo $float + 7; ?><br />
        /: <?php echo 4/3; ?><br />
        Round: <?php echo round($float, 1) ?><br />
        Ceiling: <?php echo ceil($float) ?><br />
        Floor: <?php echo floor($float) ?><br />

        <h3>Checking</h3>
        <?php $integer = 3; ?>
        <?php echo "Is {$integer} an integer? " . is_int($integer); ?><br />
        <?php echo "Is {$float} an integer? " . is_int($float); ?><br />
        <?php echo "Is {$integer} a float? " . is_float($float); ?><br />
        <?php echo "Is {$float} a float? " . is_float($integer); ?><br />
        <?php echo "Is {$integer} a numeric? " . is_numeric($integer); ?><br />
        <?php echo "Is {$float} a numeric? " . is_numeric($float); ?><br />

        <h3>Warning</h3>
        Can't / 0: <?php echo 4/0; ?><br />
    </body>
</html>