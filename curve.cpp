#include <iostream>
#include <iomanip>
#include <cmath>

#define PI 3.141592;

double radian(double angle) {
  return (angle / 180) * PI; 
}

void get_vertices(int parts, double height, double in_radius, double out_radius, double s_angle, double e_angle, int side) {
  for (int i = 0; i < parts; ++i) {
    double a = s_angle + i * (e_angle / parts);
    double b = a + (e_angle / parts);

    std::cout << std::fixed;
    
    if (side) {
      std::cout << "// Plane " << i+1 << std::endl;
      std::cout << std::setprecision(5) << in_radius * sin(a) << ", " << height - (i * height / parts) << ", " << in_radius * cos(a) << std::endl;
      std::cout << std::setprecision(5) << out_radius * sin(a) << ", " << height - (i * height / parts) << ", " << out_radius * cos(a) << std::endl;
      
      std::cout << std::setprecision(5) << in_radius * sin(b) << ", " << height - ((i+1) * height / parts) << ", " << in_radius * cos(b) << std::endl;
      std::cout << std::setprecision(5) << out_radius * sin(b) << ", " << height - ((i+1) * height / parts) << ", " << out_radius * cos(b) << std::endl;
    }
    
    if (!side) {
      std::cout << "// Plane " << i+1 << std::endl;
      std::cout << std::setprecision(5) << in_radius * sin(b) << ", " << height - ((i+1) * height / parts) << ", " << in_radius * cos(b) << std::endl;
      std::cout << std::setprecision(5) << out_radius * sin(b) << ", " << height - ((i+1) * height / parts) << ", " << out_radius * cos(b) << std::endl;
      
      std::cout << std::setprecision(5) << in_radius * sin(a) << ", " << height - (i * height / parts) << ", " << in_radius * cos(a) << std::endl;
      std::cout << std::setprecision(5) << out_radius * sin(a) << ", " << height - (i * height / parts) << ", " << out_radius * cos(a) << std::endl;
    }

  }
}

int main() {
  get_vertices(8, .75, 2, 3, radian(90), radian(90), 1);
  std::cout << std::endl;
  get_vertices(8, .75, 2, 3, radian(90), radian(90), 0);
  return 0;
}