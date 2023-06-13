<html lang='en'>
    <head>
        <title>PHP Integers</title>
    </head>
    <body>
        <h3>Math Function</h3>
        <?php
            $var1 = 4;
            $var2 = 3;
        ?>
        Basic math: <?php echo (1+2)*$var1/$var2-5; ?><br />
        Absolute val: <?php echo abs(0-300); ?><br />
        Exponential: <?php echo pow(2,8); ?><br />
        Square Root: <?php echo sqrt(100); ?><br />
        Modulo: <?php echo fmod(20,7); ?><br />
        Random: <?php echo rand(); ?><br />
        Random (from range): <?php echo rand(1, 10); ?><br />
        <h3>Just like in C</h3>
        += : <?php $var2 += 4; echo $var2; ?><br />
        -= : <?php $var2 -= 4; echo $var2; ?><br />
        *= : <?php $var2 *= 4; echo $var2; ?><br />
        /= : <?php $var2 /= 3; echo $var2; ?><br />
        ++ : <?php $var2++; echo $var2; ?><br />
        -- : <?php $var2--; echo $var2; ?><br />
    </body>
</html>