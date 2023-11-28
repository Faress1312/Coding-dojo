from flask_app import app
from flask import render_template,redirect,request,session
from flask_app.models.user import User

@app.route('/')
def gome():
    return render_template("index.html")
@app.route ('/register' , methods =['post'])
def register():
    print("😶‍🌫️😶"*10,request.form , "😶‍🌫️😶"*10)
    # if User.validate(requ)
    data = {**request.form}
    if User.validate(data) :
    User.create(data)
    return redirect("/")