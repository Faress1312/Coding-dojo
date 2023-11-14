class Student :
    # class attributes : belong only to the class and accessible to all objects of the class
    school_name = "dojo"
    # 1 constructor 
    def __init__(self , dict_data) :
        # instance Attributes
        if Student.validate_student(dict_data)
            self.name = dict_data ['name']
            self.age = dict_data ['age']
            self.group = dict_data ['group'] 
            self.fav_food = dict_data ['fav_food']
        else : 
            

    def increase_age(self, years=1) :
        self.age+= years
        print("happy Birthday")
        return self
    def change_name(self, new_name) :
        self.name = new_name 
        return self
    def __repr__(self) :
        return f"Student  Name : {self.name}\n"
    @classmethod
    def change_school_name(cls, new_name) : 
        cls.school_name = new_name
    @staticmethod
    def validate_student(data) :


john_data = {'name' :"john" , 'age':21, 'group': 'A3', 'fav_food' : 'kkk'}
fares_data = {'name' :"fares" , 'age':24, 'group': 'C3', 'fav_food' : 'azk'}

john = Student(john_data)
fares = Student(fares_data)

print(john.school_name)
print(fares.school_name)
Student.change_school_name("NewDojo")
# Instance Methods : methods accessible by the instances 
    # can change instance attributes
    # default parameter : self
    # no  decorator

# Class Methods : methods accessible only by the class 
    # can change class attributes (school_name)
    # default parameter : cls
    # decorator : @classmethods
    
# Static Methods : methods that has no access to attributes 
        # Stationnairy Methods 
        # For validation and utility
        # decorator @staticmethod