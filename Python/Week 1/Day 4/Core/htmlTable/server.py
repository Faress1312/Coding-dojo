from flask import Flask,render_template
# Import    Flask      to     allow    us    to   create     our   app
app = Flask(__name__,template_folder='templates') 
# bech nsamo lapp flask bech najmou na3mlou app.route

@app.route('/')
def simple():

    users = [
    {'first_name' : 'Michael', 'last_name' : 'Choi'},
    {'first_name' : 'John', 'last_name' : 'Supsupin'},
    {'first_name' : 'Mark', 'last_name' : 'Guillen'},
    {'first_name' : 'KB', 'last_name' : 'Tonel'}
    ]
    return render_template("index2.html",users=users)


if __name__=="__main__":   #runs directly 
    app.run(debug=True)    # hedha lazem ykoun mawjoud bch yrunni server