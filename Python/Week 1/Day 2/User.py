class User:
    # gold_card_points = []
    def __init__(self , first_name , last_name, email, age) :
        self.first_name = first_name
        self.last_name = last_name
        self.email = email 
        self.age= age
        self.is_rewards_member = False
        self.gold_card_points = 0
    
    def display_info(self):
    
        print(self.first_name,  self.last_name,  self.email,  self.age,  self.gold_card_points)
    def enroll(self):
        self.is_rewards_member = True
        self.gold_card_points = 200
    def spend_points(self,amount):
        self.gold_card_points -= amount
fares=User(' fares',' alaya',' alayafares4@gmail.com ', 21)
fares.display_info()
fares.spend_points(10)
class User2 :
    def __init__(self , first_name , last_name, email, age) :
        self.first_name = first_name
        self.last_name = last_name
        self.email = email 
        self.age= age
        self.is_rewards_member = False
        self.gold_card_points = 300
    def display_info(self):
        print(self.first_name,  self.last_name,  self.email,  self.age ,  self.gold_card_points)
    def spend_points(self,amount):
        self.gold_card_points -= amount
bisa=User2('Bisa','Rjeb','Bisarejeb232@gmail.com','24')
bisa.display_info()
bisa.spend_points(50)
class User3 :
    def __init__(self , first_name , last_name, email, age) :
        self.first_name = first_name
        self.last_name = last_name
        self.email = email 
        self.age= age
        self.is_rewards_member = False
        self.gold_card_points = 1000.00
    def enroll(self):
        self.is_rewards_member = True
        self.gold_card_points = 1000.00
    def display_info(self):
        print(self.first_name,  self.last_name,  self.email,  self.age ,  self.gold_card_points)
    def spend_points(self,amount):
        self.gold_card_points -= amount
nigga=User3('nigga','gafsa','niggagafsi@gmail.com','30')
nigga.display_info()
nigga.spend_points(80)