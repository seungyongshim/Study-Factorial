#include <iostream>


constexpr const uint64_t factorial(const uint64_t v)
{
    return v == 0 ? 1 : factorial(v - 1) * v;
}

int main()
{
    std::cout << factorial(15);
}

// complete compile-time 
// 
