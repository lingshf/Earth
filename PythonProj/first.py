import requests
import BeautifulSoup
r = requests.get("http://www.baidu.com/")
r.encoding = r.apparent_encoding
print(r.text)
