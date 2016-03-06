# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    Makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: mmashego <marvin@42.fr>                    +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2016/02/18 14:36:33 by mmashego          #+#    #+#              #
#    Updated: 2016/02/18 14:39:44 by mmashego         ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

NAME = ft_cat

SRC = ft_cat.c

all: $(NAME)

$(NAME):
		gcc -c -Wall -Werror -Wextra $(SRC)
		ar rc $(NAME) ft_cat.o

clean:
	/bin/rm -f ft_cat.o

fclean: clean
	/bin/rm -f $(NAME)

re: fclean all
