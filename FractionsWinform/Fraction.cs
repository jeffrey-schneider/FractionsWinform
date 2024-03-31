namespace FractionsWinform
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public int Unit { get; set; }

        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction(int unit, int numerator, int denominator)
        {
            this.Unit = unit;
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public Fraction(Fraction other)
        {
            this.Unit = other.Unit;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
        }


        public Fraction Add(Fraction other)
        {
            return Add(this, other);
            //Fraction retFraction = new Fraction();
            //int lcd = FindLCD(this.Denominator, other.Denominator);

            ////Adjust numerators based on LCD
            //int adjustedNumerator1 = this.Numerator * (lcd / this.Denominator);
            //int adjustedNumerator2 = other.Numerator * (lcd / other.Denominator);

            ////Add numerators
            //int sum = adjustedNumerator1 + adjustedNumerator2;
            //retFraction.Numerator = sum;
            //retFraction.Denominator = lcd;
            //retFraction.Unit = this.Unit + other.Unit;
            //retFraction.Simplify();
            //return retFraction;
        }

        public static Fraction Add(Fraction f0, Fraction f1)
        {
            Fraction retFraction = new Fraction();
            int lcd = FindLCD(f0.Denominator, f1.Denominator);

            //Adjust numerators based on LCD
            int adjustedNumerator1 = f0.Numerator * (lcd / f0.Denominator);
            int adjustedNumerator2 = f1.Numerator * (lcd / f1.Denominator);

            //Add numerators
            int sum = adjustedNumerator1 + adjustedNumerator2;
            retFraction.Numerator = sum;
            retFraction.Denominator = lcd;
            retFraction.Unit = f0.Unit + f1.Unit;
            retFraction.Simplify();
            return retFraction;
        }

        public Fraction Subtract(Fraction other)
        {
            return Subtract(this, other);
        }

        public static Fraction Subtract(Fraction f0, Fraction f1)
        {
            Fraction retFraction = new Fraction();
            int lcd = FindLCD(f0.Denominator, f1.Denominator);
            //Adjust numerators based on LCD
            int adjustedNumerator1 = f0.Numerator * (lcd / f0.Denominator);
            int adjustedNumerator2 = f1.Numerator * (lcd / f1.Denominator);

            //Subtract numerators
            int difference = adjustedNumerator1 - adjustedNumerator2;
            retFraction.Numerator = difference;
            retFraction.Denominator = lcd;
            retFraction.Unit = f0.Unit - f1.Unit;
            retFraction.Simplify();
            return retFraction;
        }

        public Fraction Multiply(Fraction other)
        {
            return Multiply(this, other);
        }

        public static Fraction Multiply(Fraction f0, Fraction f1)
        {
            int improper1 = ImproperFraction(f0);
            int improper2 = ImproperFraction(f1);

            //Multiply numerators and denominators
            int numerator = improper1 * improper2;
            int denominator = f0.Denominator * f1.Denominator;
            Fraction returnFraction = new Fraction(numerator, denominator);
            returnFraction.Simplify();
            return returnFraction;
        }

        public Fraction Divide(Fraction other)
        {
            return Divide(this, other);
        }

        public static Fraction Divide(Fraction f0, Fraction f1)
        {
            // Convert both mixed fractions to improper fractions
            Fraction improper1 = ToImproperFraction(f0);
            Fraction improper2 = ToImproperFraction(f1);

            // Invert the second fraction and then multiply
            Fraction invertedFraction2 = new Fraction(0, improper2.Denominator, improper2.Numerator);
            return Multiply(improper1, invertedFraction2);
        }


        public static Fraction ToImproperFraction(Fraction mixedFraction)
        {
            // Convert mixed number to improper fraction
            int numerator = mixedFraction.Unit * mixedFraction.Denominator + mixedFraction.Numerator;
            return new Fraction(0, numerator, mixedFraction.Denominator);
        }

        public static int ImproperFraction(Fraction fraction)
        {
            return fraction.Unit * fraction.Denominator + fraction.Numerator;
        }

        public void Simplify()
        {
            Simplify(this);
        }

        public static void Simplify(Fraction f0)
        {
            int numerator = f0.Unit * f0.Denominator + f0.Numerator;

            //Simplify fraction
            int gcd = FindGCD(numerator, f0.Denominator);
            numerator /= gcd;
            int denominator = f0.Denominator / gcd;

            //Convert improper fraction back to mixed number
            int whole = numerator / denominator;
            numerator %= denominator;
            f0.Unit = whole;
            f0.Numerator = numerator;
            f0.Denominator = denominator;
        }

        public static int FindLCD(int denominator1, int denominator2)
        {
            // Find LCD
            int gcd = FindGCD(denominator1, denominator2);
            int lcd = (denominator1 * denominator2) / gcd;
            return lcd;
        }

        public static int FindGCD(int a, int b)
        {
            //Euclidean algorithm to find GCD
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            //return $"{Unit}  {Numerator}/{Denominator}";
            if (this.Unit != 0 && this.Numerator != 0)
                return $"{Unit} {Numerator}/{Denominator}";
            else if (this.Unit != 0)
                return $"{Unit}";
            else if (this.Numerator != 0)
                return $"{Numerator}/{Denominator}";
            else
                return "0";
        }
    }
}
