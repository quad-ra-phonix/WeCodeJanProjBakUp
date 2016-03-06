# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    Makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: mmashego <marvin@42.fr>                    +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2016/02/18 14:15:50 by mmashego          #+#    #+#              #
#    Updated: 2016/02/18 14:20:58 by mmashego         ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

NAME = ft_display_file

SRC = ft_display_file.c

all: $(NAME)

$(NAME): 
		gcc -c -Wall -Werror -Wextra $(SRC)
		ar rc $(NAME) ft_display.o

clean:
	/bin/rm -f ft_display_file.o

fclean: clean
		/bin/rm -f $(NAME)

re: fclean all
