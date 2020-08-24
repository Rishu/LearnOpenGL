# define the C++ compiler to use
CC := gcc
CXX := clang++  # or g++

# define any compile-time flags
CFLAGS := -Wall -g
CXXFLAGS := -std=c++17 -stdlib=libc++ -Wall

# define any directories containing header files other than /usr/include
#
includes := -I../../include

# define library paths in addition to /usr/lib
#   if I wanted to include libraries not in /usr/lib I'd specify
#   their path using -Lpath, something like:
# LFLAGS = -L/home/newhall/lib  -L../lib

# define any libraries to link into executable:
#   if I want to link in libraries (libx.so or libx.a) I use the -llibname 
#   option, something like (this will link in libmylib.so and libm.so:

libs := -lglfw

# define the C source files
csrc :=  ../glad.c

# define the C++ source files
cxxsrc := hello_triangle_excercise_1.cpp

# create output folder
build   = ./build
bin     = ./bin

# define the C & C++ object files 
objects := $(patsubst %.c,$(build)/%.o,$(csrc)) $(patsubst %.cpp,$(build)/%.o,$(cxxsrc))
out_objects := $(subst ../,,$(objects))

# create build and binary directory
$(info $(shell mkdir -p $(build)))
$(info $(shell mkdir -p $(bin)))

# define the executable file 
out := hello_triangle_excercise_1

.PHONY: clean

all: $(out)
	@echo  Simple compiler named mycc has been compiled

$(out): $(objects)
	$(CXX) $(CXXFLAGS) $(includes) $(libs) -o $(bin)/$(out) $(out_objects)

# # this is a suffix replacement rule for building .o's from .c's
# # it uses automatic variables $<: the name of the prerequisite of
# # the rule(a .c file) and $@: the name of the target of the rule (a .o file) 
# # (see the gnu make manual section about automatic variables)
$(build)/%.o: %.c
	$(CC) -c $(CFLAGS) $(includes) $< -o $(subst ../,,$@)

$(build)/%.o: %.cpp
	$(CXX) -c $(CXXFLAGS) $(includes) $< -o $@

clean:
	$(RM) $(build)/*.o *~ $(bin)/$(out)
	rm -rf $(bin)
	rm -rf $(build)
