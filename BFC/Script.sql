INSERT INTO Category VALUES (1, 'Хлебобулочные изделия');
INSERT INTO Category VALUES (2, 'Молочные продукты, жиры');
INSERT INTO Category VALUES (3, 'Мясо и мясные продукты');
INSERT INTO Category VALUES (4, 'Супы');
INSERT INTO Category VALUES (5, 'Каши');
INSERT INTO Category VALUES (6, 'Рыба и рыбные продукты');
INSERT INTO Category VALUES (7, 'Крупы, макаронные изделия');
INSERT INTO Category VALUES (8, 'Сахар, кондитерские изделия');
INSERT INTO Category VALUES (9, 'Овощи');
INSERT INTO Category VALUES (10, 'Фрукты, ягоды, орехи');
INSERT INTO Category VALUES (11, 'Напитки');
INSERT INTO Category VALUES (12, 'Другое');


INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Хлеб ржаной', 5.1, 1, 42.5, 204, 1);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Хлеб пшеничный', 5.8, 0.5, 56.1, 268, 1);
INSERT INTO FoodList(Name, Proteins, Fats, Carbohydrates, Calories, Category_id)  VALUES ('Молоко коровье', 2.8, 3.5, 4.5, 62, 2);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Кумыс', 1.6, 1.4, 3.7, 35, 2);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Кролик', 18, 7, null, 140, 3);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Шашлык', 19.2, 24.8, null, 310, 3);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Солянка', 3.3, 10.5, 6.6, 134, 4);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Сёмга', 19, 12, null, 190, 6);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Гречневая каша', 3.2, 0.2, 14.1, 90, 5);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Рис', 6.7, 0.9, 72.8, 334, 7);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Варенье', 0.3, null, 74.2, 300, 8);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Огурцы', 0.8, null, 2, 11, 9);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Арбуз', 0.5, null, 7.7, 33, 10);
INSERT INTO FoodList (Name, Proteins, Fats, Carbohydrates, Calories, Category_id) VALUES ('Чай без сахара', null, null, null, null, 11);


