<html lang='en'>
    <head>
        <title>PHP Associative Arrays</title>
    </head>
    <body>
        <?php
            // associative arrays are object-indexed instead
            // key-value pairs:
            $assoc = array("first_name" => "Kevin", "last_name" => "Skoglung");
        ?><br />
        <?php
            // accessed similar to js object properties
            echo "Hello {$assoc['first_name']}.";
        ?><br />
        <?php
            echo "Wait, {$assoc['first_name']} {$assoc['last_name']}??";
        ?><br />
        <pre>
            <?php echo print_r($assoc); ?>
        </pre><br />
        <?php
            // update values by object:
            $assoc["first_name"] = "Larry";
            echo "Oh, {$assoc['first_name']} {$assoc['last_name']}??";
            // can also use integer-based indexes:
            echo $assoc[0];
            // what if we try calling the first index?
            $assoc[0] = 1;
        ?><br />
        <?php
            // integer-based indexes are stored as their own objects:
            echo $assoc[0];
            $assoc[0] = 1;
        ?><br />
        <pre>
            <?php echo print_r($assoc); ?>
        </pre><br />
    </body>
</html>