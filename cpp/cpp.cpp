#include <iostream>

using namespace std;

constexpr const uint64_t factorial(const uint64_t v)
{
    return v == 0 ? 1 : factorial(v - 1) * v;
}

constexpr const uint64_t factorial_tail(const uint64_t v, const uint64_t acc = 1)
{
    return v == 0 ? 1 : factorial_tail(v - 1, acc * v);
}

int main()
{
    cout << factorial(15) << endl;
    cout << factorial_tail(15) << endl;
}
