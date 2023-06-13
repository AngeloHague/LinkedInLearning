<html lang='en'>
    <head>
        <title>PHP Nulls and Empties</title>
    </head>
    <body>
        <?php
            // can be lower or upper
            // null or NULL
            $var1 = null;
            $var2 = "";
            // is_null checks for null
            // isset checks if defined
            // empty checks for: "", null, 0, 0.0, "0", false, array()
        ?>
        Is var1 null? <?php echo is_null($var1) ?><br />
        Is var1 set? <?php echo isset($var1) ?><br />
        Is var1 empty? <?php echo empty($var1) ?><br /><br />
        Is var2 null? <?php echo is_null($var2) ?><br />
        Is var2 set? <?php echo isset($var2) ?><br />
        Is var2 empty? <?php echo empty($var2) ?><br /><br />
        Is var3 (undefined) set? <?php echo isset($var3) ?><br />
        Is var3 (undefined) null? <?php echo is_null($var3) ?><br />
        Is var3 (undefined) empty? <?php echo empty($var3) ?><br />
    </body>
</html>