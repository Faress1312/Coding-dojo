# ?OOP= Object Oriented Programming 
# ?class= template or blueprint to create objects (instances)


# Attributes = what the obeject can have :characterstics :nouns
# Methods = what the object can do : functions inside the class : actions : verbs

class car :
    #1 Constructor
    def __init__(self , make_value , model_value , power_value = True) :
        
        # attributes =value
        self.model= model_value
        self.make= make_value
        self.power = power_value
    # Methods 
        def model(self):
        self.model = Mercedes-Benz
        print(self.model):
        return self
    print