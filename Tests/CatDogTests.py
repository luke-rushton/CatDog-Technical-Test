import requests

url = 'https://localhost:7204/CatDog'
myobj = {'cat': 'dog'}
x = requests.post(url, json = myobj)

print(x.text)