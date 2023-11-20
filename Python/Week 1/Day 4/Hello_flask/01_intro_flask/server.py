
from flask import Flask , render_template
app= Flask(__name__)

@app.route('/')
def hello_world():
    return 'Hello world'

@app.route('/hello') 
def hello() :
    return "hello from server !😢"

@app.route('/hello/user')
def say_hello():
    return f"<h1> Hello ME 🍍🍍</h1>"

@app.route('/hello/user/<username>')
def say_hello_username(username):
    return f"<h1> Hello {username} 😶‍🌫️😶‍🌫️🍍🍍</h1>"

@app.route('/hello/user/<username>/<int:times>')
def say_hello_user_n_times(username, times):
    return f"<h1>Hello {username} 😒😶‍🌫️</h1>" * times

@app.route('/user/<username>/<int:age>')
def user_info(username,age):
    return f"<h1>USERNAME : {username} <br/> AGE : {age} </h1>"

@app.route('/index/<username>/<int:age>')
def index(username, age):
    users =[
        {'name': 'fmetaz','age ': 34},
        {'name': 'had','age ': 44},
        {'name': 'john','age ': 24},
        {'name': 'nicki','age ': 14},
        {'name': 'johnaa','age ': 54}]
    return render_template("index.html", user=username , number= age , users=users)

if __name__ =="__main__":
    app.run(debug=True, port=1337)
