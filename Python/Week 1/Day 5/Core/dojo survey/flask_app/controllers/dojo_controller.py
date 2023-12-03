from flask_app import app

from flask import render_template, request, session, redirect


@app.route('/')
def index():
    return render_template("index.html")


@app.route("/register", methods=["POST"])
def register():
    
    session["first_name"] = request.form["first_name"]
    session["last_name"] = request.form["last_name"]
    

    return redirect("/result")