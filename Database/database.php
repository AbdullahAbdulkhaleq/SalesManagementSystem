<?php
$serverName = "."; // Replace with your SQL Server name or IP address
$connectionOptions = array(
    "Database" => "SalesManagementSystem", // Replace with your database name
    "Uid" => "", // Replace with your SQL Server username
    "PWD" => "" // Replace with your SQL Server password
);

// Establish the connection
$conn = sqlsrv_connect($serverName, $connectionOptions);
if ($conn === false) {
    die(print_r(sqlsrv_errors(), true));
}

// Perform database operations
// ...

// Close the connection
sqlsrv_close($conn);