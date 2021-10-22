# One_Array_Tree_Stacks

Tek bir dizi içerisinde 3 stack tutma işlemini alanı verimli şekilde kullanmak için iki ekstra dizi kullanma methodu ile yaptım.

1. arr[]:3 stack'i aynı anda tutacağımız ana diziyi temsil eder.
2. top[]:Bu dizi stack boyutunu tutar ve tüm stacklerin üst öğelerini dizide saklar.
3. next[]:Bu dizi stacklere girilecek değerlerin boyutundadır ve ana dizimiz olan arr[] dizisi girecek olan öğeleri saklar.
4. free:arr[] içerisindeki boş yuva,depolamak için kullandığımız değişken.
5. n:Stack boyutunu gireceğimiz değer.

Pushlamak için kaç öğe gireceğimiz proje kısmında belirttikten sonra arr[] dizimiz belirtilen boyuta göre açılır.<br />
top[] dizisi tüm giriş ve stacklerin boş olduğunu belirtmek için -1 olarak başlatılır.<br />
next[] dizisi döngü yardımıyla girilen stack değerlerini tutar ve döngü sonunda listenin sonu boş tutacak şekilde -1 ekler.<br />
Stacke pushlamak yaptığımız zaman free değerimiz 0 ise yerin olduğunu ve girilen stack değerinin direk ana dizimiz olan arr[] aktarmasını sağlar fakat -1 olduğu durumda overflow taşma olduğunu gösterir.<br />
top[] dizimize tekrar döndüğümüzde ise girilen stack değerinin hangi stacke girdiğine göre -1 olan kısım 0a döner ve aynı kısma tekrardan öğe eklenirse 0 olan 1 2 3 şeklinde stack boyutu kadar artış sağlar.<br />
next[] dizimizde top[] dizisi olduğu gibi girilen değere göre top[] dizisinden gelen değeri next[] dizisinde ilgili yere yazar.






