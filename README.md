# PHP-API-with-client-example
This is my first PHP API with client example on C#.

# Action List: 

# Login
To Login you must send POST request to index.php file with GET param 'act'.
So you must to send POST request to this link: index.php?act=login, with POST params uname and password.
# Register
You must to send POST request to this link: index.php?act=register, with POST params uname, password and email.

Both of this actions will return you answer in JSON format
Example of the return:
> {"successful":false,"error":"fill all required fields!"}.

So if "successful" is true the answer will be like this:

> {"successful":true,"error":null, "uid": "login"}.

The uid depends on your login


# Get Hotels List
To get hotel list you must to send GET request to this link: index.php?act=getHotels.

Also to get hotel list you need to have 'uid' which you will get only when you passed login/registration.
The API will return you hotel list like this: 
> {"successful":true,"hotels": [{"id":"1","hotelName":"Hotel1","city":"Kiev","country":"Ukraine","stars":"5","cost":"300","info":"Info1","image":"https:\/\/images.pexels.com\/photos\/46710\/pexels-photo-46710.jpeg?auto=compress&cs=tinysrgb&h=350"},{"id":"2","hotelName":"Hotel2","city":"New York","country":"USA","stars":"5","cost":"500","info":"Info2","image":"https:\/\/images.pexels.com\/photos\/46710\/pexels-photo-46710.jpeg?auto=compress&cs=tinysrgb&h=350"}]}


# Get Comments list from 
