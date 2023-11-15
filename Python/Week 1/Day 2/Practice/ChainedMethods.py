class User:
    def __init__(self , first_name , last_name , age , my_budget=2000.0 , i_deal= 'Mrigel') :
        self.first_name = first_name
        self.last_name = last_name
        self.age = age
        self.my_budget = my_budget
        self.i_deal = i_deal
    def display_info(self):
        print(f"My first name is {self.first_name} \n My last name is {self.last_name} \n My age is {self.age}\n My budget is {self.my_budget} \n My answer is {self.i_deal}")
        # return self
    def enroll(self) :
        if self.my_budget >=1200 :
            print("Hell yeah i can afford it")
        elif self.i_deal == True :
            print("Okey then Deal bro ! ! ")
    # return self
Fares=User('Fares','Alaya',20,)
Fares.display_info()
