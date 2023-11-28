from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import database

class User:
    def init(self,data_dict):
        self.id=data_dict['id']
        self.first_name=data_dict['first_name']
        self.last_name=data_dict['last_name']
        self.email=data_dict['email']
        self.password=data_dict['password']
        self.created_at=data_dict['created_at']
        self.updated_at=data_dict['updated_at']
    # Queries =classmethod
    @classmethod
    def create(cls,data):
        query="""INSERT INTO users
        (first_name, last_name, email, password) 
        VALUES (%(id)s,%(first_name)s,%(last_name)s,%(email)s,%(password)s);"""
        #.-.INSERT . STATEMENT RETURNS THE NEW INSERTED ROW ID
        db_result=connectToMySQL(DATABASE).query_db(query,data)
        return db_result

    @staticmethod
    def validate(data):
        is_valid = True
        if data['first_name']<2 :
            is_valid = False
        if data['last_name']<2 :
            is_valid = False
        return is_valid