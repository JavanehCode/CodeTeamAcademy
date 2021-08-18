# ||=====================================================================================================||
# ||To use the test file press "Ctrl + Shift + p" and then type python test, Then select Debug all tests ||
# ||Notice: You should create your functions within the "__init__.py"                                    ||
# ||=====================================================================================================||

import unittest
from Calculator import my_sum , my_mulpiply , my_divide , my_subtract

class TestAddTwoNumber(unittest.TestCase):

    def test_sum_two_number(self):
        self.assertEqual(my_sum(10 , 20) , 30 )
        self.assertEqual(my_sum(-10 , 20) , 10 )
        self.assertEqual(my_sum(10 , -20) , -10 )
        self.assertEqual(my_sum(-10 , -20) , -30 )

        self.assertRaises(TypeError , my_sum , 10,"ali")


class TestMultiplyTwoNumber(unittest.TestCase):

    def test_multiply_two_number(self):
        self.assertEqual(my_mulpiply(10 , 20), 200)
        self.assertEqual(my_mulpiply(-10 , 20), -200)
        self.assertEqual(my_mulpiply(10 , -20), -200)
        self.assertEqual(my_mulpiply(-10 , -20), 200)
        self.assertEqual(my_mulpiply("ali",2), "aliali")

        self.assertRaises(TypeError , my_mulpiply , "ali", "ali")

class TestDivideTwoNumber(unittest.TestCase):

    def test_divide_two_number(self):
        self.assertEqual(my_divide(10 , 20), 0.5)
        self.assertEqual(my_divide(-10 , 20), -0.5)
        self.assertEqual(my_divide(10 , -20), -0.5)
        self.assertEqual(my_divide(-10 , -20), 0.5)

        self.assertRaises(ValueError, my_divide , 10 , 0)
        self.assertRaises(TypeError , my_divide , 10 , "ali")


class TestSubtractTwoNumber(unittest.TestCase):

    def test_subtract_two_number(self):
        self.assertEqual(my_subtract(-20 , 30) , -50)
        self.assertEqual(my_subtract(20 , -30) , 50)
        self.assertEqual(my_subtract(-20 , -30) , 10)
        self.assertEqual(my_subtract(20 , 30) , -10)

        self.assertRaises(TypeError , my_subtract , 10,"ali")
       

if __name__ == "__main__":
    unittest.main()