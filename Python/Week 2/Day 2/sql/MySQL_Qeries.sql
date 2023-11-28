INSERT INTO users (first_name , last_name , email) VALUES ( "newnew ", "alaya" , "a@fe.com") ;
INSERT INTO
 users (first_name , last_name , email) 
VALUES 
    ( "fares ", "alaya" , "a@fe.com"),
    ( " amin ", "awabdia" , "aa@fa.com"),
    ( "fadi ", "panda" , "fp@fr.com"),
    ( "ahmd ", "mohsen" , "am@f.com");
    
    SELECT first_name , last_name FROM users ;
SELECT * FROM users ;
SELECT * FROM  users WHERE id =3 ;
SELECT * FROM  users WHERE first_name = "FARES" ;
SELECT * FROM users WHERE first_name LIKE "f%" ;
SELECT * FROM users WHERE first_name LIKE "%s" ;
SELECT * FROM users Order BY first_name ;
SELECT * FROM users Order BY first_name DESC;
SELECT * FROM users Order BY id DESC ;
SELECT * FROM users WHERE id<3 ;
UPDATE users SET first_name = "george" , last_name="test " ;
UPDATE users SET first_name = "george" , last_name="test "WHERE first_name = "amin" ;
UPDATE users SET first_name = "george" , last_name="test "WHERE is =10 ;
DELETE FROM users WHERE id=10 ; 
DELETE FROM users WHERE id=7 ;
SELECT CONCAT_WS("-", first_name ,last_name) FROM users ;
