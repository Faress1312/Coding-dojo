from flask import Flask , render_template 
app = Flask(__name__)
print(__name__)

@app.route( '/')
def index():
    return render_template("index.html", row=8 , col=8 , color1="red" ,color2="black")


@app.route( '/<int:x>')
def index_x(x):
    return render_template("index.html", row=x , col=8 , color1="red" ,color2="black")

@app.route( '/<int:x>/<int:y>')
def index_x_y(x,y):
    return render_template("index.html", row=x , col=y , color1="red" ,color2="black")

@app.route( '/<int:x>/<int:y>/<string:color1>')
def index_x_y_color(x,y,color1):
    return render_template("index.html", row=x , col=y , color1=color1 ,color2="black")

@app.route( '/<int:x>/<int:y>/<string:color1>/<string:color2>')
def index_x_y_colors(x,y,color1,color2):
    return render_template("index.html", row=x , col=y , color1=color1 ,color2=color2)

if __name__== "__main__":   
    app.run(debug=True, port=5000) 